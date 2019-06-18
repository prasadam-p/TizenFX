using System;
using System.Xml;
using System.Reflection;
using System.Linq;
using Tizen.NUI.XamlBinding;
using System.ComponentModel;

namespace Tizen.NUI.Xaml
{
    /// <summary>
    /// The class StaticResourceExtension.
    /// </summary>
    /// <since_tizen> 6 </since_tizen>
    /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContentProperty("Key")]
    public sealed class StaticResourceExtension : IMarkupExtension
    {
        /// <summary>
        /// Attribute Key
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Key { get; set; }

        /// <summary>
        /// Provide value tye service provideer.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));
            if (Key == null) {
                var lineInfoProvider = serviceProvider.GetService(typeof(IXmlLineInfoProvider)) as IXmlLineInfoProvider;
                var lineInfo = (lineInfoProvider != null) ? lineInfoProvider.XmlLineInfo : new XmlLineInfo();
                throw new XamlParseException("you must specify a key in {StaticResource}", lineInfo);
            }
            var valueProvider = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideParentValues;
            if (valueProvider == null)
                throw new ArgumentException();
            var xmlLineInfoProvider = serviceProvider.GetService(typeof(IXmlLineInfoProvider)) as IXmlLineInfoProvider;
            var xmlLineInfo = xmlLineInfoProvider != null ? xmlLineInfoProvider.XmlLineInfo : null;
            object resource = null;

            foreach (var p in valueProvider.ParentObjects) {
                var irp = p as Tizen.NUI.Binding.IResourcesProvider;
                var resDict = irp != null && irp.IsResourcesCreated ? irp.XamlResources : p as ResourceDictionary;
                if (resDict == null)
                    continue;
                if (resDict.TryGetValue(Key, out resource))
                    break;
            }
            resource = resource ?? GetApplicationLevelResource(Key, xmlLineInfo);

            var bp = valueProvider.TargetProperty as BindableProperty;
            var pi = valueProvider.TargetProperty as PropertyInfo;
            var propertyType = bp?.ReturnType ?? pi?.PropertyType;
            if (propertyType == null) {
                if (resource != null) {
                    if (resource.GetType().GetTypeInfo().IsGenericType && (resource.GetType().GetGenericTypeDefinition() == typeof(OnPlatform<>) || resource.GetType().GetGenericTypeDefinition() == typeof(OnIdiom<>))) {
                        // This is only there to support our backward compat story with pre 2.3.3 compiled Xaml project who was not providing TargetProperty
                        var method = resource.GetType().GetRuntimeMethod("op_Implicit", new[] { resource.GetType() });
                        if (method != null) {
                            resource = method.Invoke(null, new[] { resource });
                        }
                    }
                }
                return resource;
            }
            if (propertyType.IsAssignableFrom(resource?.GetType()))
                return resource;
            var implicit_op =  resource?.GetType().GetImplicitConversionOperator(fromType: resource?.GetType(), toType: propertyType)
                            ?? propertyType.GetImplicitConversionOperator(fromType: resource?.GetType(), toType: propertyType);
            if (implicit_op != null)
                return implicit_op.Invoke(resource, new [] { resource });

            if (resource != null) { 
                //Special case for https://bugzilla.xamarin.com/show_bug.cgi?id=59818
                //On OnPlatform, check for an opImplicit from the targetType
                if (   Device.Flags != null
                    && Device.Flags.Contains("xamlDoubleImplicitOpHack")
                    && resource.GetType().GetTypeInfo().IsGenericType
                    && (resource.GetType().GetGenericTypeDefinition() == typeof(OnPlatform<>))) {
                    var tType = resource.GetType().GenericTypeArguments[0];
                    var opImplicit = tType.GetImplicitConversionOperator(fromType: tType, toType: propertyType)
                                    ?? propertyType.GetImplicitConversionOperator(fromType: tType, toType: propertyType);

                    if (opImplicit != null) {
                        //convert the OnPlatform<T> to T
                        var opPlatformImplicitConversionOperator = resource?.GetType().GetImplicitConversionOperator(fromType: resource?.GetType(), toType: tType);
                        resource = opPlatformImplicitConversionOperator?.Invoke(null, new[] { resource });

                        //and convert to toType
                        resource = opImplicit.Invoke(null, new[] { resource });
                        return resource;
                    }
                }
            }
            return resource;
        }

        internal object GetApplicationLevelResource(string key, IXmlLineInfo xmlLineInfo)
        {
            object resource = null;
            if (Application.Current == null || !((Tizen.NUI.Binding.IResourcesProvider)Application.Current).IsResourcesCreated || !Application.Current.XamlResources.TryGetValue(Key, out resource))
                throw new XamlParseException($"StaticResource not found for key {Key}", xmlLineInfo);
            return resource;
        }
    }
}
/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

    using System;
    using System.Runtime.InteropServices;


public class Builder : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Builder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Builder_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Builder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Builder() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Builder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



    public class QuitEventArgs : EventArgs
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate void QuitEventCallbackDelegate();
    private DaliEventHandler<object,QuitEventArgs> _builderQuitEventHandler;
    private QuitEventCallbackDelegate _builderQuitEventCallbackDelegate;

    public event DaliEventHandler<object,QuitEventArgs> Quit
    {
      add
      {
        lock(this)
        {
          // Restricted to only one listener
          if (_builderQuitEventHandler == null)
          {
            _builderQuitEventHandler += value;

            _builderQuitEventCallbackDelegate = new QuitEventCallbackDelegate(OnQuit);
            this.QuitSignal().Connect(_builderQuitEventCallbackDelegate);
          }
        }
      }

      remove
      {
        lock(this)
        {
          if (_builderQuitEventHandler != null)
          {
            this.QuitSignal().Disconnect(_builderQuitEventCallbackDelegate);
          }

          _builderQuitEventHandler -= value;
        }
      }
    }

    // Callback for Builder QuitSignal
    private void OnQuit()
    {
      QuitEventArgs e = new QuitEventArgs();

      if (_builderQuitEventHandler != null)
      {
        //here we send all data to user event handlers
        _builderQuitEventHandler(this, e);
      }
    }

    ///
  public void LoadFromFile( string fileName )
  {
    try
    {
      string json = System.IO.File.ReadAllText( fileName );
      if( json.Length > 0 )
      {
        LoadFromString( json );
      }
      else
      {
        throw new global::System.InvalidOperationException("Failed to load file " +fileName);

      }
    }
    catch ( System.Exception e)
    {
      throw new global::System.InvalidOperationException("Failed to parse " +fileName);
    }
  }


    
  public Builder () : this (NDalicPINVOKE.Builder_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public void LoadFromString(string data, Builder.UIFormat format) {
    NDalicPINVOKE.Builder_LoadFromString__SWIG_0(swigCPtr, data, (int)format);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadFromString(string data) {
    NDalicPINVOKE.Builder_LoadFromString__SWIG_1(swigCPtr, data);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddConstants(Property.Map map) {
    NDalicPINVOKE.Builder_AddConstants(swigCPtr, Property.Map.getCPtr(map));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddConstant(string key, Property.Value value) {
    NDalicPINVOKE.Builder_AddConstant(swigCPtr, key, Property.Value.getCPtr(value));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Property.Map GetConstants() {
    Property.Map ret = new Property.Map(NDalicPINVOKE.Builder_GetConstants(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Property.Value GetConstant(string key) {
    Property.Value ret = new Property.Value(NDalicPINVOKE.Builder_GetConstant(swigCPtr, key), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation CreateAnimation(string animationName) {
    Animation ret = new Animation(NDalicPINVOKE.Builder_CreateAnimation__SWIG_0(swigCPtr, animationName), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation CreateAnimation(string animationName, Property.Map map) {
    Animation ret = new Animation(NDalicPINVOKE.Builder_CreateAnimation__SWIG_1(swigCPtr, animationName, Property.Map.getCPtr(map)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation CreateAnimation(string animationName, Actor sourceActor) {
    Animation ret = new Animation(NDalicPINVOKE.Builder_CreateAnimation__SWIG_2(swigCPtr, animationName, Actor.getCPtr(sourceActor)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation CreateAnimation(string animationName, Property.Map map, Actor sourceActor) {
    Animation ret = new Animation(NDalicPINVOKE.Builder_CreateAnimation__SWIG_3(swigCPtr, animationName, Property.Map.getCPtr(map), Actor.getCPtr(sourceActor)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseHandle Create(string templateName) {
    BaseHandle ret = new BaseHandle(NDalicPINVOKE.Builder_Create__SWIG_0(swigCPtr, templateName), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseHandle Create(string templateName, Property.Map map) {
    BaseHandle ret = new BaseHandle(NDalicPINVOKE.Builder_Create__SWIG_1(swigCPtr, templateName, Property.Map.getCPtr(map)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseHandle CreateFromJson(string json) {
    BaseHandle ret = new BaseHandle(NDalicPINVOKE.Builder_CreateFromJson(swigCPtr, json), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ApplyStyle(string styleName, Handle handle) {
    bool ret = NDalicPINVOKE.Builder_ApplyStyle(swigCPtr, styleName, Handle.getCPtr(handle));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ApplyFromJson(Handle handle, string json) {
    bool ret = NDalicPINVOKE.Builder_ApplyFromJson(swigCPtr, Handle.getCPtr(handle), json);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddActors(Actor toActor) {
    NDalicPINVOKE.Builder_AddActors__SWIG_0(swigCPtr, Actor.getCPtr(toActor));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddActors(string sectionName, Actor toActor) {
    NDalicPINVOKE.Builder_AddActors__SWIG_1(swigCPtr, sectionName, Actor.getCPtr(toActor));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CreateRenderTask(string name) {
    NDalicPINVOKE.Builder_CreateRenderTask(swigCPtr, name);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameBufferImage GetFrameBufferImage(string name) {
    FrameBufferImage ret = new FrameBufferImage(NDalicPINVOKE.Builder_GetFrameBufferImage(swigCPtr, name), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Path GetPath(string name) {
    Path ret = new Path(NDalicPINVOKE.Builder_GetPath(swigCPtr, name), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PathConstrainer GetPathConstrainer(string pathConstrainerName) {
    PathConstrainer ret = new PathConstrainer(NDalicPINVOKE.Builder_GetPathConstrainer(swigCPtr, pathConstrainerName), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LinearConstrainer GetLinearConstrainer(string linearConstrainerName) {
    LinearConstrainer ret = new LinearConstrainer(NDalicPINVOKE.Builder_GetLinearConstrainer(swigCPtr, linearConstrainerName), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VoidSignal QuitSignal() {
    VoidSignal ret = new VoidSignal(NDalicPINVOKE.Builder_QuitSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum UIFormat {
    JSON
  }

}

}

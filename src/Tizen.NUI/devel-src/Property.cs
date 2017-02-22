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

public class Property : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Property() {
    DisposeQueue.Instance.Add(this);
  }

  public virtual void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Property(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public static int INVALID_INDEX {
    get {
      int ret = NDalicPINVOKE.Property_INVALID_INDEX_get();
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int INVALID_KEY {
    get {
      int ret = NDalicPINVOKE.Property_INVALID_KEY_get();
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int INVALID_COMPONENT_INDEX {
    get {
      int ret = NDalicPINVOKE.Property_INVALID_COMPONENT_INDEX_get();
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Property(Handle arg0, int propertyIndex) : this(NDalicPINVOKE.new_Property__SWIG_0(Handle.getCPtr(arg0), propertyIndex), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Property(Handle arg0, int propertyIndex, int componentIndex) : this(NDalicPINVOKE.new_Property__SWIG_1(Handle.getCPtr(arg0), propertyIndex, componentIndex), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Property(Handle arg0, string propertyName) : this(NDalicPINVOKE.new_Property__SWIG_2(Handle.getCPtr(arg0), propertyName), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Property(Handle arg0, string propertyName, int componentIndex) : this(NDalicPINVOKE.new_Property__SWIG_3(Handle.getCPtr(arg0), propertyName, componentIndex), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Handle _object {
    set {
      NDalicPINVOKE.Property__object_set(swigCPtr, Handle.getCPtr(value));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Handle ret = new Handle(NDalicPINVOKE.Property__object_get(swigCPtr), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int propertyIndex {
    set {
      NDalicPINVOKE.Property_propertyIndex_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = NDalicPINVOKE.Property_propertyIndex_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int componentIndex {
    set {
      NDalicPINVOKE.Property_componentIndex_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = NDalicPINVOKE.Property_componentIndex_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public class Array : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Array(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Array obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Array() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Property_Array(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property.Value this[uint index]
    {
      get
      {
        return ValueOfIndex(index);
      }
    }
  
    public Array() : this(NDalicPINVOKE.new_Property_Array__SWIG_0(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Array(Property.Array other) : this(NDalicPINVOKE.new_Property_Array__SWIG_1(Property.Array.getCPtr(other)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public uint Size() {
      uint ret = NDalicPINVOKE.Property_Array_Size(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public uint Count() {
      uint ret = NDalicPINVOKE.Property_Array_Count(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Empty() {
      bool ret = NDalicPINVOKE.Property_Array_Empty(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public void Clear() {
      NDalicPINVOKE.Property_Array_Clear(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void Reserve(uint size) {
      NDalicPINVOKE.Property_Array_Reserve(swigCPtr, size);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void Resize(uint size) {
      NDalicPINVOKE.Property_Array_Resize(swigCPtr, size);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public uint Capacity() {
      uint ret = NDalicPINVOKE.Property_Array_Capacity(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public void PushBack(Property.Value value) {
      NDalicPINVOKE.Property_Array_PushBack(swigCPtr, Property.Value.getCPtr(value));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Property.Array Add(Property.Value value) {
      Property.Array ret = new Property.Array(NDalicPINVOKE.Property_Array_Add(swigCPtr, Property.Value.getCPtr(value)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value GetElementAt(uint index) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Array_GetElementAt__SWIG_0(swigCPtr, index), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value ValueOfIndex(uint index) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Array_ValueOfIndex__SWIG_0(swigCPtr, index), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Array Assign(Property.Array other) {
      Property.Array ret = new Property.Array(NDalicPINVOKE.Property_Array_Assign(swigCPtr, Property.Array.getCPtr(other)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class Key : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Key(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Key obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Key() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Property_Key(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property.Key.Type type {
      set {
        NDalicPINVOKE.Property_Key_type_set(swigCPtr, (int)value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        Property.Key.Type ret = (Property.Key.Type)NDalicPINVOKE.Property_Key_type_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public int indexKey {
      set {
        NDalicPINVOKE.Property_Key_indexKey_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        int ret = NDalicPINVOKE.Property_Key_indexKey_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public string stringKey {
      set {
        NDalicPINVOKE.Property_Key_stringKey_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        string ret = NDalicPINVOKE.Property_Key_stringKey_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public Key(string key) : this(NDalicPINVOKE.new_Property_Key__SWIG_0(key), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Key(int key) : this(NDalicPINVOKE.new_Property_Key__SWIG_1(key), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public bool EqualTo(string rhs) {
      bool ret = NDalicPINVOKE.Property_Key_EqualTo__SWIG_0(swigCPtr, rhs);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool EqualTo(int rhs) {
      bool ret = NDalicPINVOKE.Property_Key_EqualTo__SWIG_1(swigCPtr, rhs);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool EqualTo(Property.Key rhs) {
      bool ret = NDalicPINVOKE.Property_Key_EqualTo__SWIG_2(swigCPtr, Property.Key.getCPtr(rhs));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool NotEqualTo(string rhs) {
      bool ret = NDalicPINVOKE.Property_Key_NotEqualTo__SWIG_0(swigCPtr, rhs);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool NotEqualTo(int rhs) {
      bool ret = NDalicPINVOKE.Property_Key_NotEqualTo__SWIG_1(swigCPtr, rhs);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool NotEqualTo(Property.Key rhs) {
      bool ret = NDalicPINVOKE.Property_Key_NotEqualTo__SWIG_2(swigCPtr, Property.Key.getCPtr(rhs));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public enum Type {
      INDEX,
      STRING
    }
  
  }

  public class Map : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Map(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Map obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Map() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Property_Map(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property.Value this[string key]
    {
      get
      {
        return ValueOfIndex(key);
      }
    }
  
    public Property.Value this[int key]
    {
      get
      {
        return ValueOfIndex(key);
      }
    }
  
    public Map() : this(NDalicPINVOKE.new_Property_Map__SWIG_0(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Map(Property.Map other) : this(NDalicPINVOKE.new_Property_Map__SWIG_1(Property.Map.getCPtr(other)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public uint Count() {
      uint ret = NDalicPINVOKE.Property_Map_Count(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Empty() {
      bool ret = NDalicPINVOKE.Property_Map_Empty(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public void Insert(string key, Property.Value value) {
      NDalicPINVOKE.Property_Map_Insert__SWIG_0(swigCPtr, key, Property.Value.getCPtr(value));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void Insert(int key, Property.Value value) {
      NDalicPINVOKE.Property_Map_Insert__SWIG_2(swigCPtr, key, Property.Value.getCPtr(value));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Property.Map Add(string key, Property.Value value) {
      Property.Map ret = new Property.Map(NDalicPINVOKE.Property_Map_Add__SWIG_0(swigCPtr, key, Property.Value.getCPtr(value)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Map Add(int key, Property.Value value) {
      Property.Map ret = new Property.Map(NDalicPINVOKE.Property_Map_Add__SWIG_2(swigCPtr, key, Property.Value.getCPtr(value)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value GetValue(uint position) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Map_GetValue(swigCPtr, position), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public string GetKey(uint position) {
      string ret = NDalicPINVOKE.Property_Map_GetKey(swigCPtr, position);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Key GetKeyAt(uint position) {
      Property.Key ret = new Property.Key(NDalicPINVOKE.Property_Map_GetKeyAt(swigCPtr, position), true);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public StringValuePair GetPair(uint position) {
      StringValuePair ret = new StringValuePair(NDalicPINVOKE.Property_Map_GetPair(swigCPtr, position), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value Find(string key) {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Map_Find__SWIG_0(swigCPtr, key);
      Property.Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Value(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value Find(int key) {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Map_Find__SWIG_2(swigCPtr, key);
      Property.Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Value(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value Find(int indexKey, string stringKey) {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Map_Find__SWIG_3(swigCPtr, indexKey, stringKey);
      Property.Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Value(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value Find(string key, Property.Type type) {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Map_Find__SWIG_4(swigCPtr, key, (int)type);
      Property.Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Value(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value Find(int key, Property.Type type) {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Map_Find__SWIG_5(swigCPtr, key, (int)type);
      Property.Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Value(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public void Clear() {
      NDalicPINVOKE.Property_Map_Clear(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void Merge(Property.Map from) {
      NDalicPINVOKE.Property_Map_Merge(swigCPtr, Property.Map.getCPtr(from));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Property.Value ValueOfIndex(string key) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Map_ValueOfIndex__SWIG_0(swigCPtr, key), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Value ValueOfIndex(int key) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Map_ValueOfIndex__SWIG_2(swigCPtr, key), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Map Assign(Property.Map other) {
      Property.Map ret = new Property.Map(NDalicPINVOKE.Property_Map_Assign(swigCPtr, Property.Map.getCPtr(other)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class Value : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Value(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Value obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Value() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Property_Value(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
  
      // Extension to property value class that allows us to create a
      // PropertyValue from a C# object, e.g. int, float, string
      static public Property.Value CreateFromObject( System.Object obj)
      {
        System.Type type = obj.GetType ();
  
          Property.Value value;
  
          if ( type.Equals (typeof(int)) )
          {
            //Console.WriteLine (" got an int property value ");
            value = new Property.Value ((int) obj );
          }
          if ( type.Equals (typeof(System.Int32)) )
          {
            //Console.WriteLine (" got an int property value ");
            value = new Property.Value ((int) obj );
          }
          else if ( type.Equals (typeof(bool)) )
          {
            //Console.WriteLine (" got an bool property value ");
            value = new Property.Value ((bool) obj );
          }
          else if ( type.Equals (typeof(float)) )
          {
            //Console.WriteLine (" got an float property value ");
            value = new Property.Value ((float) obj );
          }
          else if ( type.Equals (typeof(string)) )
          {
            //Console.WriteLine (" got a string property value ");
            value = new Property.Value ((string) obj );
          }
          else if ( type.Equals (typeof(Vector2)) )
          {
            //Console.WriteLine (" got an Vector2 property value ");
            value = new Property.Value ((Vector2) obj );
          }
          else if ( type.Equals (typeof(Vector3)) )
          {
            //Console.WriteLine (" got an Vector3 property value ");
            value = new Property.Value ((Vector3) obj );
          }
          else if ( type.Equals (typeof(Vector4)) )
          {
            //Console.WriteLine (" got an Vector4 property value ");
  
            value = new Property.Value ((Vector4) obj );
          }
          else if ( type.Equals (typeof(Position)) )
          {
            //Console.WriteLine (" got an Position property value ");
            value = new Property.Value ((Position) obj );
          }
          else if ( type.Equals (typeof(Size)) )
          {
            //Console.WriteLine (" got an Size property value ");
            value = new Property.Value ((Size) obj );
          }
          else if ( type.Equals (typeof(Color)) )
          {
            //Console.WriteLine (" got an Color property value ");
            value = new Property.Value ((Color) obj );
          }
          else
          {
             throw new global::System.InvalidOperationException("Unimplemented type for Property Value");
          }
          return  value;
      }
  
  
   
    public Value() : this(NDalicPINVOKE.new_Property_Value__SWIG_0(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(bool boolValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_1(boolValue), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(int integerValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_2(integerValue), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(float floatValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_3(floatValue), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Vector2 vectorValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_4(Vector2.getCPtr(vectorValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Vector3 vectorValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_5(Vector3.getCPtr(vectorValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Vector4 vectorValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_6(Vector4.getCPtr(vectorValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Matrix3 matrixValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_7(Matrix3.getCPtr(matrixValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Matrix matrixValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_8(Matrix.getCPtr(matrixValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Rectangle vectorValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_9(Rectangle.getCPtr(vectorValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(AngleAxis angleAxis) : this(NDalicPINVOKE.new_Property_Value__SWIG_10(AngleAxis.getCPtr(angleAxis)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Quaternion quaternion) : this(NDalicPINVOKE.new_Property_Value__SWIG_11(Quaternion.getCPtr(quaternion)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(string stringValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_12(stringValue), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Property.Array arrayValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_14(Property.Array.getCPtr(arrayValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Property.Map mapValue) : this(NDalicPINVOKE.new_Property_Value__SWIG_15(Property.Map.getCPtr(mapValue)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Property.Type type) : this(NDalicPINVOKE.new_Property_Value__SWIG_16((int)type), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Value(Property.Value value) : this(NDalicPINVOKE.new_Property_Value__SWIG_17(Property.Value.getCPtr(value)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Property.Value Assign(Property.Value value) {
      Property.Value ret = new Property.Value(NDalicPINVOKE.Property_Value_Assign(swigCPtr, Property.Value.getCPtr(value)), false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Type GetType() {
      Property.Type ret = (Property.Type)NDalicPINVOKE.Property_Value_GetType(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(ref bool boolValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_1(swigCPtr, ref boolValue);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(ref float floatValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_2(swigCPtr, ref floatValue);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(ref int integerValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_3(swigCPtr, ref integerValue);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Rectangle rect) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_4(swigCPtr, Rectangle.getCPtr(rect));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Vector2 vectorValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_5(swigCPtr, Vector2.getCPtr(vectorValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Vector3 vectorValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_6(swigCPtr, Vector3.getCPtr(vectorValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Vector4 vectorValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_7(swigCPtr, Vector4.getCPtr(vectorValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Matrix3 matrixValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_8(swigCPtr, Matrix3.getCPtr(matrixValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Matrix matrixValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_9(swigCPtr, Matrix.getCPtr(matrixValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(AngleAxis angleAxisValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_10(swigCPtr, AngleAxis.getCPtr(angleAxisValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Quaternion quaternionValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_11(swigCPtr, Quaternion.getCPtr(quaternionValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(out string stringValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_12(swigCPtr, out stringValue);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Property.Array arrayValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_13(swigCPtr, Property.Array.getCPtr(arrayValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool Get(Property.Map mapValue) {
      bool ret = NDalicPINVOKE.Property_Value_Get__SWIG_14(swigCPtr, Property.Map.getCPtr(mapValue));
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Array GetArray() {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Value_GetArray(swigCPtr);
      Property.Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Array(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Property.Map GetMap() {
      global::System.IntPtr cPtr = NDalicPINVOKE.Property_Value_GetMap(swigCPtr);
      Property.Map ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property.Map(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public enum Type {
    NONE,
    BOOLEAN,
    FLOAT,
    INTEGER,
    VECTOR2,
    VECTOR3,
    VECTOR4,
    MATRIX3,
    MATRIX,
    RECTANGLE,
    ROTATION,
    STRING,
    ARRAY,
    MAP
  }

  public enum AccessMode {
    READ_ONLY,
    READ_WRITE,
    ANIMATABLE,
    ACCESS_MODE_COUNT
  }

}

}

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

public class TableView : View {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TableView(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.TableView_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TableView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TableView() {
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
          NDalicPINVOKE.delete_TableView(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


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
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_TableView_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_TableView_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int ROWS = NDalicPINVOKE.TableView_Property_ROWS_get();
    public static readonly int COLUMNS = NDalicPINVOKE.TableView_Property_COLUMNS_get();
    public static readonly int CELL_PADDING = NDalicPINVOKE.TableView_Property_CELL_PADDING_get();
    public static readonly int LAYOUT_ROWS = NDalicPINVOKE.TableView_Property_LAYOUT_ROWS_get();
    public static readonly int LAYOUT_COLUMNS = NDalicPINVOKE.TableView_Property_LAYOUT_COLUMNS_get();
  
  }

  public class ChildProperty : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ChildProperty(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChildProperty obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ChildProperty() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_TableView_ChildProperty(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ChildProperty() : this(NDalicPINVOKE.new_TableView_ChildProperty(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int CELL_INDEX = NDalicPINVOKE.TableView_ChildProperty_CELL_INDEX_get();
    public static readonly int ROW_SPAN = NDalicPINVOKE.TableView_ChildProperty_ROW_SPAN_get();
    public static readonly int COLUMN_SPAN = NDalicPINVOKE.TableView_ChildProperty_COLUMN_SPAN_get();
    public static readonly int CELL_HORIZONTAL_ALIGNMENT = NDalicPINVOKE.TableView_ChildProperty_CELL_HORIZONTAL_ALIGNMENT_get();
    public static readonly int CELL_VERTICAL_ALIGNMENT = NDalicPINVOKE.TableView_ChildProperty_CELL_VERTICAL_ALIGNMENT_get();
  
  }

  public class CellPosition : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal CellPosition(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CellPosition obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~CellPosition() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_TableView_CellPosition(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public CellPosition(uint rowIndex, uint columnIndex, uint rowSpan, uint columnSpan) : this(NDalicPINVOKE.new_TableView_CellPosition__SWIG_0(rowIndex, columnIndex, rowSpan, columnSpan), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public CellPosition(uint rowIndex, uint columnIndex, uint rowSpan) : this(NDalicPINVOKE.new_TableView_CellPosition__SWIG_1(rowIndex, columnIndex, rowSpan), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public CellPosition(uint rowIndex, uint columnIndex) : this(NDalicPINVOKE.new_TableView_CellPosition__SWIG_2(rowIndex, columnIndex), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public CellPosition(uint rowIndex) : this(NDalicPINVOKE.new_TableView_CellPosition__SWIG_3(rowIndex), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public CellPosition() : this(NDalicPINVOKE.new_TableView_CellPosition__SWIG_4(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public uint rowIndex {
      set {
        NDalicPINVOKE.TableView_CellPosition_rowIndex_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NDalicPINVOKE.TableView_CellPosition_rowIndex_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint columnIndex {
      set {
        NDalicPINVOKE.TableView_CellPosition_columnIndex_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NDalicPINVOKE.TableView_CellPosition_columnIndex_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint rowSpan {
      set {
        NDalicPINVOKE.TableView_CellPosition_rowSpan_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NDalicPINVOKE.TableView_CellPosition_rowSpan_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint columnSpan {
      set {
        NDalicPINVOKE.TableView_CellPosition_columnSpan_set(swigCPtr, value);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = NDalicPINVOKE.TableView_CellPosition_columnSpan_get(swigCPtr);
        if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
  }

  public TableView (uint initialRows, uint initialColumns) : this (NDalicPINVOKE.TableView_New(initialRows, initialColumns), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public TableView(TableView handle) : this(NDalicPINVOKE.new_TableView__SWIG_1(TableView.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TableView Assign(TableView handle) {
    TableView ret = new TableView(NDalicPINVOKE.TableView_Assign(swigCPtr, TableView.getCPtr(handle)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static TableView DownCast(BaseHandle handle) {
    TableView ret = new TableView(NDalicPINVOKE.TableView_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddChild(Actor child, TableView.CellPosition position) {
    bool ret = NDalicPINVOKE.TableView_AddChild(swigCPtr, Actor.getCPtr(child), TableView.CellPosition.getCPtr(position));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Actor GetChildAt(TableView.CellPosition position) {
    Actor ret = new Actor(NDalicPINVOKE.TableView_GetChildAt(swigCPtr, TableView.CellPosition.getCPtr(position)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Actor RemoveChildAt(TableView.CellPosition position) {
    Actor ret = new Actor(NDalicPINVOKE.TableView_RemoveChildAt(swigCPtr, TableView.CellPosition.getCPtr(position)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FindChildPosition(Actor child, TableView.CellPosition position) {
    bool ret = NDalicPINVOKE.TableView_FindChildPosition(swigCPtr, Actor.getCPtr(child), TableView.CellPosition.getCPtr(position));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void InsertRow(uint rowIndex) {
    NDalicPINVOKE.TableView_InsertRow(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteRow(uint rowIndex) {
    NDalicPINVOKE.TableView_DeleteRow__SWIG_0(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteRow(uint rowIndex, ActorContainer removed) {
    NDalicPINVOKE.TableView_DeleteRow__SWIG_1(swigCPtr, rowIndex, ActorContainer.getCPtr(removed));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertColumn(uint columnIndex) {
    NDalicPINVOKE.TableView_InsertColumn(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteColumn(uint columnIndex) {
    NDalicPINVOKE.TableView_DeleteColumn__SWIG_0(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteColumn(uint columnIndex, ActorContainer removed) {
    NDalicPINVOKE.TableView_DeleteColumn__SWIG_1(swigCPtr, columnIndex, ActorContainer.getCPtr(removed));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Resize(uint rows, uint columns) {
    NDalicPINVOKE.TableView_Resize__SWIG_0(swigCPtr, rows, columns);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Resize(uint rows, uint columns, ActorContainer removed) {
    NDalicPINVOKE.TableView_Resize__SWIG_1(swigCPtr, rows, columns, ActorContainer.getCPtr(removed));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCellPadding(Vector2 padding) {
    NDalicPINVOKE.TableView_SetCellPadding(swigCPtr, Vector2.getCPtr(padding));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 GetCellPadding() {
    Vector2 ret = new Vector2(NDalicPINVOKE.TableView_GetCellPadding(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFitHeight(uint rowIndex) {
    NDalicPINVOKE.TableView_SetFitHeight(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsFitHeight(uint rowIndex) {
    bool ret = NDalicPINVOKE.TableView_IsFitHeight(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFitWidth(uint columnIndex) {
    NDalicPINVOKE.TableView_SetFitWidth(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsFitWidth(uint columnIndex) {
    bool ret = NDalicPINVOKE.TableView_IsFitWidth(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFixedHeight(uint rowIndex, float height) {
    NDalicPINVOKE.TableView_SetFixedHeight(swigCPtr, rowIndex, height);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetFixedHeight(uint rowIndex) {
    float ret = NDalicPINVOKE.TableView_GetFixedHeight(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRelativeHeight(uint rowIndex, float heightPercentage) {
    NDalicPINVOKE.TableView_SetRelativeHeight(swigCPtr, rowIndex, heightPercentage);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetRelativeHeight(uint rowIndex) {
    float ret = NDalicPINVOKE.TableView_GetRelativeHeight(swigCPtr, rowIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFixedWidth(uint columnIndex, float width) {
    NDalicPINVOKE.TableView_SetFixedWidth(swigCPtr, columnIndex, width);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetFixedWidth(uint columnIndex) {
    float ret = NDalicPINVOKE.TableView_GetFixedWidth(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRelativeWidth(uint columnIndex, float widthPercentage) {
    NDalicPINVOKE.TableView_SetRelativeWidth(swigCPtr, columnIndex, widthPercentage);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetRelativeWidth(uint columnIndex) {
    float ret = NDalicPINVOKE.TableView_GetRelativeWidth(swigCPtr, columnIndex);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetRows() {
    uint ret = NDalicPINVOKE.TableView_GetRows(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetColumns() {
    uint ret = NDalicPINVOKE.TableView_GetColumns(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCellAlignment(TableView.CellPosition position, HorizontalAlignmentType horizontal, VerticalAlignmentType vertical) {
    NDalicPINVOKE.TableView_SetCellAlignment(swigCPtr, TableView.CellPosition.getCPtr(position), (int)horizontal, (int)vertical);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000,
    CHILD_PROPERTY_START_INDEX = PropertyRanges.CHILD_PROPERTY_REGISTRATION_START_INDEX,
    CHILD_PROPERTY_END_INDEX = PropertyRanges.CHILD_PROPERTY_REGISTRATION_START_INDEX+1000
  }

  public enum LayoutPolicy {
    FIXED,
    RELATIVE,
    FILL,
    FIT
  }

  public int Rows
  {
    get
    {
      int temp = 0;
      GetProperty( TableView.Property.ROWS).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TableView.Property.ROWS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public int Columns
  {
    get
    {
      int temp = 0;
      GetProperty( TableView.Property.COLUMNS).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TableView.Property.COLUMNS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector2 CellPadding
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( TableView.Property.CELL_PADDING).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TableView.Property.CELL_PADDING, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map LayoutRows
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TableView.Property.LAYOUT_ROWS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TableView.Property.LAYOUT_ROWS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map LayoutColumns
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TableView.Property.LAYOUT_COLUMNS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TableView.Property.LAYOUT_COLUMNS, new Tizen.NUI.Property.Value( value ) );
    }
  }

}

}

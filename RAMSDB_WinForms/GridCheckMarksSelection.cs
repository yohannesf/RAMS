using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Drawing;
using System.Collections.Generic;
using DevExpress.XtraEditors.ViewInfo;

namespace RAMSDB_WinForms
{
    public class GridCheckMarksSelection
    {
        protected GridView _view;
        protected ArrayList selection;
        GridColumn column;
        RepositoryItemCheckEdit edit;
        const int CheckboxIndent = 4;

        public GridCheckMarksSelection()
        {
            selection = new ArrayList();
            DisabledRecords = new List<object>();
        }

        public GridCheckMarksSelection(GridView view)
            : this()
        {
            View = view;
        }
        public GridView View
        {
            get { return _view; }
            set
            {
                if (_view != value)
                {
                    Detach();
                    Attach(value);
                }
            }
        }

        public List<object> DisabledRecords { set; get; }

        public GridColumn CheckMarkColumn { get { return column; } }

        public int SelectedCount { get { return selection.Count; } }
        public object GetSelectedRow(int index)
        {
            return selection[index];
        }
        public int GetSelectedIndex(object row)
        {
            return selection.IndexOf(row);
        }
        public void ClearSelection()
        {
            selection.Clear();
            Invalidate();
        }
        public void SelectAll()
        {
            selection.Clear();
            // fast (won't work if the grid is filtered)
            //if(_view.DataSource is ICollection)
            //	selection.AddRange(((ICollection)_view.DataSource));
            //else
            // slow:
            for (int i = 0; i < _view.DataRowCount; i++)
            {
                if (!IsRowDisabled(_view.GetRow(i)))
                    selection.Add(_view.GetRow(i));
            }
            Invalidate();
        }
        public void SelectGroup(int rowHandle, bool select)
        {
            if (IsGroupRowSelected(rowHandle) && select) return;
            for (int i = 0; i < _view.GetChildRowCount(rowHandle); i++)
            {
                int childRowHandle = _view.GetChildRowHandle(rowHandle, i);
                if (_view.IsGroupRow(childRowHandle))
                    SelectGroup(childRowHandle, select);
                else
                    SelectRow(childRowHandle, select, false);
            }
            Invalidate();
        }
        public void SelectRow(int rowHandle, bool select)
        {
            
            SelectRow(rowHandle, select, true);
        }
        public void InvertRowSelection(int rowHandle)
        {
          
            if (View.IsDataRow(rowHandle))
            {
                
                SelectRow(rowHandle, !IsRowSelected(rowHandle));
            }
            if (View.IsGroupRow(rowHandle))
            {
                SelectGroup(rowHandle, !IsGroupRowSelected(rowHandle));
            }
        }

        bool IsRowDisabled(int rowHandle)
        {
            return DisabledRecords.Contains(View.GetRow(rowHandle));
        }
        bool IsRowDisabled(object row)
        {
            return DisabledRecords.Contains(row);
        }

        public bool IsGroupRowSelected(int rowHandle)
        {
            bool thereIsValidRowInGroup = false;
            bool result = true;
            for (int i = 0; i < _view.GetChildRowCount(rowHandle); i++)
            {
                int row = _view.GetChildRowHandle(rowHandle, i);
                if (_view.IsGroupRow(row))
                {
                    if (!IsGroupRowSelected(row)) result =  false;
                }
                else
                {
                    if (!thereIsValidRowInGroup && !DisabledRecords.Contains(View.GetRow(row)))
                        thereIsValidRowInGroup = true;
                    if (!IsRowSelectedOrDisabled(row)) result = false;
                }
                    
            }
            if (View.GetRowLevel(rowHandle) != View.GroupCount - 1)
                return result;
            result = thereIsValidRowInGroup  ? result : false;
            return result;
        }
        public bool IsRowSelected(int rowHandle)
        {
            if (_view.IsGroupRow(rowHandle))
                return IsGroupRowSelected(rowHandle);

            object row = _view.GetRow(rowHandle);
            return GetSelectedIndex(row) != -1;
        }

        public bool IsRowSelectedOrDisabled(int rowHandle)
        {
            bool selected = IsRowSelected(rowHandle);
            bool disabled = IsRowDisabled(rowHandle);
            return selected || disabled;
        }

        protected virtual void Attach(GridView view)
        {
            if (view == null) return;
            selection.Clear();
            this._view = view;
            view.BeginUpdate();
            try
            {
                edit = view.GridControl.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

                column = view.Columns.Add();
                column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                column.Visible = true;
                column.VisibleIndex = 0;
                column.FieldName = "CheckMarkSelection";
                column.Caption = "Mark";
                column.OptionsColumn.ShowCaption = false;
                column.OptionsColumn.AllowEdit = false;
                column.OptionsColumn.AllowSize = false;
                column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
                column.Width = GetCheckBoxWidth();
                column.ColumnEdit = edit;

                view.Click += new EventHandler(View_Click);
                view.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
                view.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
                view.CustomUnboundColumnData += new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
                view.KeyDown += new KeyEventHandler(view_KeyDown);
                view.RowStyle += new RowStyleEventHandler(view_RowStyle);
                view.CustomDrawCell += view_CustomDrawCell;
            }
            finally
            {
                view.EndUpdate();
            }
        }

    

       

        void view_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
             if (e.Column.FieldName == "CheckMarkSelection")
            {
              if (!IsRowDisabled(e.RowHandle)) return;
              CheckEditViewInfo cvi =  ((DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo)(e.Cell)).ViewInfo as CheckEditViewInfo;
              cvi.AllowOverridedState = true;
              cvi.OverridedState = ObjectState.Disabled;
              cvi.CalcViewInfo(e.Graphics);
            }
        }

        protected virtual void Detach()
        {
            if (_view == null) return;
            if (column != null)
                column.Dispose();
            if (edit != null)
            {
                _view.GridControl.RepositoryItems.Remove(edit);
                edit.Dispose();
            }

            _view.Click -= new EventHandler(View_Click);
            _view.CustomDrawColumnHeader -= new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            _view.CustomDrawGroupRow -= new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            _view.CustomUnboundColumnData -= new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            _view.KeyDown -= new KeyEventHandler(view_KeyDown);
            _view.RowStyle -= new RowStyleEventHandler(view_RowStyle);

            _view = null;
        }
        protected int GetCheckBoxWidth()
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            int width = 0;
            GraphicsInfo.Default.AddGraphics(null);
            try
            {
                width = info.CalcBestFit(GraphicsInfo.Default.Graphics).Width;
            }
            finally
            {
                GraphicsInfo.Default.ReleaseGraphics();
            }
            return width + CheckboxIndent * 2;
        }
        protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked, bool enabled = true)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;
            info.Bounds = r;
            info.AllowOverridedState = false;
            info.CalcViewInfo(g);
            //info.State = enabled == true ? ObjectState.Disabled : ObjectState.Disabled;
            info.CheckInfo.State = enabled == true ? ObjectState.Normal : ObjectState.Disabled;
          
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }
        void Invalidate()
        {
            _view.CloseEditor();
            _view.BeginUpdate();
            _view.EndUpdate();
        }
        void SelectRow(int rowHandle, bool select, bool invalidate)
        {
            if (IsRowDisabled(rowHandle)) return;
            if (IsRowSelected(rowHandle) == select) return;
            object row = _view.GetRow(rowHandle);
            if (select)
                selection.Add(row);
            else
                selection.Remove(row);
            if (invalidate)
            {
                Invalidate();
            }
        }
        void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column == CheckMarkColumn)
            {
                if (e.IsGetData)
                    e.Value = IsRowSelected(View.GetRowHandle(e.ListSourceRowIndex));
                else
                    SelectRow(View.GetRowHandle(e.ListSourceRowIndex), (bool)e.Value);
            }
        }
        void view_KeyDown(object sender, KeyEventArgs e)
        {
            if (View.FocusedColumn != column || e.KeyCode != Keys.Space) return;
            InvertRowSelection(View.FocusedRowHandle);
        }
        void View_Click(object sender, EventArgs e)
        {
            GridHitInfo info;
            Point pt = _view.GridControl.PointToClient(Control.MousePosition);
            info = _view.CalcHitInfo(pt);
            if (info.Column == column)
            {
                if (info.InColumn)
                {
                    if (SelectedCount + DisabledRecords.Count == _view.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                if (info.InRowCell)
                {
                    InvertRowSelection(info.RowHandle);
                }
            }
            if (info.InRow && _view.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
            {
                InvertRowSelection(info.RowHandle);
            }
        }

      

        void View_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == column)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e.Graphics, e.Bounds, SelectedCount + DisabledRecords.Count == _view.DataRowCount);
                e.Handled = true;
            }
        }
        void View_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info;
            info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

            info.GroupText = "         " + info.GroupText.TrimStart();
            e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds);
            e.Painter.DrawObject(e.Info);

            Rectangle r = info.ButtonBounds;
            r.Offset(r.Width + CheckboxIndent * 2 - 1, 0);
            DrawCheckBox(e.Graphics, r, IsGroupRowSelected(e.RowHandle));
            e.Handled = true;
        }
        void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = SystemColors.Highlight;
                e.Appearance.ForeColor = SystemColors.HighlightText;
            }
        }
    }
}

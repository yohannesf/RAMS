namespace RAMSDB_WinForms.Administration
{
    partial class AssignRoadsToUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignRoadsToUsers));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.roadsCrossingWoredasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoredaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZoneCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoredaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadOriginDestination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadClassificationDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadIdentifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadLengthInKm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfaceTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersAssignedEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnassign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUnassign = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.roadClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookupUserAssign = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsCrossingWoredasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAssignedEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnassign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupUserAssign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.windowsUIButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.labelControl);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(913, 616);
            this.layoutControl.TabIndex = 1;
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Location = new System.Drawing.Point(47, 0);
            this.labelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(0, 4, 15, 7);
            this.labelControl.Size = new System.Drawing.Size(819, 43);
            this.labelControl.StyleController = this.layoutControl;
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "Roads";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.roadsCrossingWoredasBindingSource;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl.Location = new System.Drawing.Point(47, 43);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnUnassign,
            this.usersAssignedEdit});
            this.gridControl.Size = new System.Drawing.Size(819, 573);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // roadsCrossingWoredasBindingSource
            // 
            this.roadsCrossingWoredasBindingSource.DataSource = typeof(RAMSDBModel.RoadsCrossingWoredas);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.colRoadID,
            this.colWoredaName,
            this.colZoneName,
            this.colZoneCode,
            this.colWoredaCode,
            this.colAdminID,
            this.colRoadOriginDestination,
            this.colRoadClassificationDescription,
            this.colRoadIdentifier,
            this.colRoadLengthInKm,
            this.colSurfaceTypeName,
            this.colUser,
            this.colUnassign});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 2;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colZoneName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWoredaName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView_CustomDrawCell);
            this.gridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView_CustomDrawGroupRow);
            this.gridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            // 
            // colSelect
            // 
            this.colSelect.Caption = "gridColumn1";
            this.colSelect.FieldName = "isSelect";
            this.colSelect.MinWidth = 25;
            this.colSelect.Name = "colSelect";
            this.colSelect.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 1;
            this.colSelect.Width = 94;
            // 
            // colRoadID
            // 
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Visible = true;
            this.colRoadID.VisibleIndex = 7;
            this.colRoadID.Width = 314;
            // 
            // colWoredaName
            // 
            this.colWoredaName.FieldName = "WoredaName";
            this.colWoredaName.MinWidth = 25;
            this.colWoredaName.Name = "colWoredaName";
            this.colWoredaName.Visible = true;
            this.colWoredaName.VisibleIndex = 1;
            this.colWoredaName.Width = 94;
            // 
            // colZoneName
            // 
            this.colZoneName.FieldName = "ZoneName";
            this.colZoneName.MinWidth = 25;
            this.colZoneName.Name = "colZoneName";
            this.colZoneName.Visible = true;
            this.colZoneName.VisibleIndex = 1;
            this.colZoneName.Width = 94;
            // 
            // colZoneCode
            // 
            this.colZoneCode.FieldName = "ZoneCode";
            this.colZoneCode.MinWidth = 25;
            this.colZoneCode.Name = "colZoneCode";
            this.colZoneCode.Width = 94;
            // 
            // colWoredaCode
            // 
            this.colWoredaCode.FieldName = "WoredaCode";
            this.colWoredaCode.MinWidth = 25;
            this.colWoredaCode.Name = "colWoredaCode";
            this.colWoredaCode.Width = 94;
            // 
            // colAdminID
            // 
            this.colAdminID.FieldName = "AdminID";
            this.colAdminID.MinWidth = 25;
            this.colAdminID.Name = "colAdminID";
            this.colAdminID.Width = 94;
            // 
            // colRoadOriginDestination
            // 
            this.colRoadOriginDestination.FieldName = "RoadOriginDestination";
            this.colRoadOriginDestination.MinWidth = 25;
            this.colRoadOriginDestination.Name = "colRoadOriginDestination";
            this.colRoadOriginDestination.Visible = true;
            this.colRoadOriginDestination.VisibleIndex = 2;
            this.colRoadOriginDestination.Width = 189;
            // 
            // colRoadClassificationDescription
            // 
            this.colRoadClassificationDescription.FieldName = "RoadClassificationDescription";
            this.colRoadClassificationDescription.MinWidth = 25;
            this.colRoadClassificationDescription.Name = "colRoadClassificationDescription";
            this.colRoadClassificationDescription.Visible = true;
            this.colRoadClassificationDescription.VisibleIndex = 3;
            this.colRoadClassificationDescription.Width = 189;
            // 
            // colRoadIdentifier
            // 
            this.colRoadIdentifier.FieldName = "RoadIdentifier";
            this.colRoadIdentifier.MinWidth = 25;
            this.colRoadIdentifier.Name = "colRoadIdentifier";
            this.colRoadIdentifier.Visible = true;
            this.colRoadIdentifier.VisibleIndex = 4;
            this.colRoadIdentifier.Width = 152;
            // 
            // colRoadLengthInKm
            // 
            this.colRoadLengthInKm.FieldName = "RoadLengthInKm";
            this.colRoadLengthInKm.MinWidth = 25;
            this.colRoadLengthInKm.Name = "colRoadLengthInKm";
            this.colRoadLengthInKm.Visible = true;
            this.colRoadLengthInKm.VisibleIndex = 5;
            this.colRoadLengthInKm.Width = 133;
            // 
            // colSurfaceTypeName
            // 
            this.colSurfaceTypeName.FieldName = "SurfaceTypeName";
            this.colSurfaceTypeName.MinWidth = 25;
            this.colSurfaceTypeName.Name = "colSurfaceTypeName";
            this.colSurfaceTypeName.Visible = true;
            this.colSurfaceTypeName.VisibleIndex = 6;
            this.colSurfaceTypeName.Width = 161;
            // 
            // colUser
            // 
            this.colUser.Caption = "Assigned to";
            this.colUser.ColumnEdit = this.usersAssignedEdit;
            this.colUser.FieldName = "colUser";
            this.colUser.MinWidth = 25;
            this.colUser.Name = "colUser";
            this.colUser.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 8;
            this.colUser.Width = 94;
            // 
            // usersAssignedEdit
            // 
            this.usersAssignedEdit.AutoHeight = false;
            this.usersAssignedEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.usersAssignedEdit.DataSource = this.userBindingSource;
            this.usersAssignedEdit.DisplayMember = "FullName";
            this.usersAssignedEdit.Name = "usersAssignedEdit";
            this.usersAssignedEdit.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.usersAssignedEdit.ValueMember = "UserID";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(RAMSDBModel.User);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUnassign
            // 
            this.colUnassign.Caption = "Unassign";
            this.colUnassign.ColumnEdit = this.btnUnassign;
            this.colUnassign.FieldName = "colUnassign";
            this.colUnassign.MinWidth = 25;
            this.colUnassign.Name = "colUnassign";
            this.colUnassign.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colUnassign.Visible = true;
            this.colUnassign.VisibleIndex = 9;
            this.colUnassign.Width = 94;
            // 
            // btnUnassign
            // 
            this.btnUnassign.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnUnassign.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Unassign road to user", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnUnassign.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnUnassign_ButtonClick);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.itemGrid});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(47, 47, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(913, 616);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.labelControl;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(819, 43);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.Location = new System.Drawing.Point(0, 43);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(819, 573);
            this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.itemGrid.TextVisible = false;
            // 
            // roadClassBindingSource
            // 
            this.roadClassBindingSource.DataSource = typeof(RAMSDB_WinForms.ViewModel.AssignRoadsToUsersVM.RoadClass);
            // 
            // gridLookupUserAssign
            // 
            this.gridLookupUserAssign.EditValue = "[Select User to Assign]";
            this.gridLookupUserAssign.Location = new System.Drawing.Point(37, 17);
            this.gridLookupUserAssign.Name = "gridLookupUserAssign";
            this.gridLookupUserAssign.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookupUserAssign.Properties.Appearance.Options.UseFont = true;
            this.gridLookupUserAssign.Properties.Appearance.Options.UseTextOptions = true;
            this.gridLookupUserAssign.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridLookupUserAssign.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridLookupUserAssign.Properties.AutoHeight = false;
            this.gridLookupUserAssign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookupUserAssign.Properties.DataSource = this.userBindingSource;
            this.gridLookupUserAssign.Properties.DisplayMember = "FullName";
            this.gridLookupUserAssign.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookupUserAssign.Properties.ValueMember = "UserID";
            this.gridLookupUserAssign.Size = new System.Drawing.Size(265, 35);
            this.gridLookupUserAssign.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colFullName,
            this.colUserName,
            this.colIsActive});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 1;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "New;Size32x32;GrayScaled";
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.ImageUri.Uri = "Preview;Size32x32;GrayScaled";
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Assign", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel.Controls.Add(this.gridLookupUserAssign);
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 616);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 74);
            this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 74);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(913, 74);
            this.windowsUIButtonPanel.TabIndex = 5;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            this.windowsUIButtonPanel.Click += new System.EventHandler(this.windowsUIButtonPanel_Click);
            // 
            // AssignRoadsToUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 690);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssignRoadsToUsers";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsCrossingWoredasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAssignedEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnassign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupUserAssign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.windowsUIButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private System.Windows.Forms.BindingSource roadClassBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colWoredaName;
        private DevExpress.XtraGrid.Columns.GridColumn colZoneName;
        private DevExpress.XtraGrid.Columns.GridColumn colZoneCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWoredaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadOriginDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClassificationDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadIdentifier;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadLengthInKm;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceTypeName;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookupUserAssign;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private DevExpress.XtraGrid.Columns.GridColumn colUnassign;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUnassign;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit usersAssignedEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource roadsCrossingWoredasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
    }
}

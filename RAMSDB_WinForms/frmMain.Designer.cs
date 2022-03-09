namespace RAMSDB_WinForms
{
    partial class frmMain
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.startGroup = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.pageGroup = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.ucUnpavedMainNavDoc = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucPavedMainNavDoc = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucPPPMainNavDoc = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucUnpavedTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.ucPPPTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.ucPavedTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.ucAdminNavigation = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucAdminTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucUnpavedMainNavDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPavedMainNavDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPPPMainNavDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucUnpavedTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPPPTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPavedTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdminNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdminTile)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.Caption = "Road Asset Management System (RAMS)";
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.startGroup,
            this.pageGroup});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.ucUnpavedMainNavDoc,
            this.ucPavedMainNavDoc,
            this.ucPPPMainNavDoc,
            this.ucAdminNavigation});
            this.windowsUIView1.LoadingIndicatorProperties.DescriptionFormat = "{0} loading...";
            this.windowsUIView1.TileProperties.AllowHtmlDraw = true;
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.ucUnpavedTile,
            this.ucPavedTile,
            this.ucPPPTile,
            this.ucAdminTile});
            // 
            // startGroup
            // 
            this.startGroup.ActivationTarget = this.pageGroup;
            this.startGroup.Caption = "Road Asset Management System";
            this.startGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.ucUnpavedTile,
            this.ucPPPTile,
            this.ucPavedTile,
            this.ucAdminTile});
            this.startGroup.Name = "startGroup";
            this.startGroup.Properties.ItemSize = 180;
            this.startGroup.Properties.RowCount = 3;
            // 
            // pageGroup
            // 
            this.pageGroup.Caption = "Road Asset Management System";
            this.pageGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucUnpavedMainNavDoc,
            this.ucPavedMainNavDoc,
            this.ucPPPMainNavDoc,
            this.ucAdminNavigation});
            this.pageGroup.Name = "pageGroup";
            this.pageGroup.Parent = this.startGroup;
            this.pageGroup.Properties.Margin = new System.Windows.Forms.Padding(40, 0, 40, 20);
            // 
            // ucUnpavedMainNavDoc
            // 
            this.ucUnpavedMainNavDoc.Caption = "Unpaved Roads ";
            this.ucUnpavedMainNavDoc.ControlName = "MainNavigation";
            this.ucUnpavedMainNavDoc.ControlTypeName = "RAMSDB_WinForms.MainNavigation";
            // 
            // ucPavedMainNavDoc
            // 
            this.ucPavedMainNavDoc.Caption = "Paved Roads ";
            this.ucPavedMainNavDoc.ControlName = "PavedMainNavigation";
            this.ucPavedMainNavDoc.ControlTypeName = "RAMSDB_WinForms.PavedMainNavigation";
            // 
            // ucPPPMainNavDoc
            // 
            this.ucPPPMainNavDoc.Caption = "Planning, Programming and Peformance Management";
            this.ucPPPMainNavDoc.ControlName = "PPPMainNavigation";
            this.ucPPPMainNavDoc.ControlTypeName = "RAMSDB_WinForms.PPPMainNavigation";
            // 
            // ucUnpavedTile
            // 
            this.ucUnpavedTile.Appearances.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUnpavedTile.Appearances.Normal.ForeColor = System.Drawing.Color.White;
            this.ucUnpavedTile.Appearances.Normal.Options.UseFont = true;
            this.ucUnpavedTile.Appearances.Normal.Options.UseForeColor = true;
            this.ucUnpavedTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucUnpavedTile.BackgroundImage")));
            this.ucUnpavedTile.Document = this.ucUnpavedMainNavDoc;
            tileItemElement1.AnchorOffset = new System.Drawing.Point(3, 3);
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement1.Text = "Unpaved Roads";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement1.TextLocation = new System.Drawing.Point(5, 5);
            this.ucUnpavedTile.Elements.Add(tileItemElement1);
            this.ucUnpavedTile.Group = "TileGroup1";
            this.ucUnpavedTile.Name = "ucUnpavedTile";
            this.ucUnpavedTile.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ucUnpavedTile.Properties.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.ucUnpavedTile.Properties.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            // 
            // ucPPPTile
            // 
            this.ucPPPTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPPPTile.BackgroundImage")));
            this.ucPPPTile.Document = this.ucPPPMainNavDoc;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            tileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement2.Text = "Planning, Programming and Performance Management";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement2.TextLocation = new System.Drawing.Point(5, 0);
            this.ucPPPTile.Elements.Add(tileItemElement2);
            this.ucPPPTile.Group = "TileGroup1";
            this.startGroup.SetID(this.ucPPPTile, 1);
            this.ucPPPTile.Name = "ucPPPTile";
            this.ucPPPTile.Properties.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.ucPPPTile.Properties.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            // 
            // ucPavedTile
            // 
            this.ucPavedTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPavedTile.BackgroundImage")));
            this.ucPavedTile.Document = this.ucPavedMainNavDoc;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Text = "Paved Roads";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement3.TextLocation = new System.Drawing.Point(5, 5);
            this.ucPavedTile.Elements.Add(tileItemElement3);
            this.ucPavedTile.Group = "TileGroup2";
            this.startGroup.SetID(this.ucPavedTile, 2);
            this.ucPavedTile.Name = "ucPavedTile";
            this.ucPavedTile.Padding = new System.Windows.Forms.Padding(0);
            this.ucPavedTile.Properties.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.ucPavedTile.Properties.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            // 
            // ucAdminNavigation
            // 
            this.ucAdminNavigation.Caption = "Administration";
            this.ucAdminNavigation.ControlName = "AdminNavigation";
            this.ucAdminNavigation.ControlTypeName = "RAMSDB_WinForms.Administration.AdminNavigation";
            // 
            // ucAdminTile
            // 
            this.ucAdminTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucAdminTile.BackgroundImage")));
            this.ucAdminTile.Document = this.ucAdminNavigation;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Administration";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement4.TextLocation = new System.Drawing.Point(5, 0);
            this.ucAdminTile.Elements.Add(tileItemElement4);
            this.ucAdminTile.Group = "TileGroup2";
            this.startGroup.SetID(this.ucAdminTile, 3);
            this.ucAdminTile.Name = "ucAdminTile";
            this.ucAdminTile.Properties.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.ucAdminTile.Properties.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 667);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.Text = "Road Asset Management System (RAMS)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucUnpavedMainNavDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPavedMainNavDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPPPMainNavDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucUnpavedTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPPPTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPavedTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdminNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdminTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucUnpavedTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucUnpavedMainNavDoc;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer startGroup;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucPavedMainNavDoc;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucPavedTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucPPPMainNavDoc;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucPPPTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucAdminNavigation;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucAdminTile;
    }
}
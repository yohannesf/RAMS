namespace RAMSDB_WinForms.Administration
{
    partial class UserAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.roadsGISDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roadsGISDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 18;
            this.cboYear.Location = new System.Drawing.Point(479, 249);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(176, 26);
            this.cboYear.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(515, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 41);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Year (GC)";
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(21, 84);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(335, 191);
            this.lblFilePath.TabIndex = 18;
            this.lblFilePath.Text = "label1";
            // 
            // roadsGISDataBindingSource
            // 
            this.roadsGISDataBindingSource.DataSource = typeof(RAMSDBModel.RoadsGISData);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(759, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserAdmin";
            this.Text = "UserAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.roadsGISDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSYear;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadIDMain;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanSet;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClass;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSectionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageStartKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageEndKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionLengthKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colXBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colYBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colXEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colYEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colStartNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEndNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneck;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneckSize;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfAssessment;
        private DevExpress.XtraGrid.Columns.GridColumn colAssessedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_SurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadsGISData;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource roadsGISDataBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button button3;
    }
}
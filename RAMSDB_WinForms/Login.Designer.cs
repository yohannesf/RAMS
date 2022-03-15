namespace RAMSDB_WinForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoginDataControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tUserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFortUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDataControl)).BeginInit();
            this.LoginDataControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LoginButton.Appearance.Options.UseFont = true;
            this.LoginButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginButton.ImageOptions.SvgImage")));
            this.LoginButton.Location = new System.Drawing.Point(180, 297);
            this.LoginButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.Silver;
            this.LoginButton.LookAndFeel.SkinName = "The Bezier";
            this.LoginButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(191, 62);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginDataControl
            // 
            this.LoginDataControl.Controls.Add(this.tUserNameTextEdit);
            this.LoginDataControl.DataSource = this.loginViewModelBindingSource;
            this.LoginDataControl.Location = new System.Drawing.Point(103, 206);
            this.LoginDataControl.Name = "LoginDataControl";
            this.LoginDataControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(546, 0, 812, 500);
            this.LoginDataControl.Root = this.layoutControlGroup1;
            this.LoginDataControl.Size = new System.Drawing.Size(385, 64);
            this.LoginDataControl.TabIndex = 5;
            this.LoginDataControl.Text = "dataLayoutControl1";
            // 
            // tUserNameTextEdit
            // 
            this.tUserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginViewModelBindingSource, "tUserName", true));
            this.tUserNameTextEdit.Location = new System.Drawing.Point(12, 12);
            this.tUserNameTextEdit.MaximumSize = new System.Drawing.Size(0, 40);
            this.tUserNameTextEdit.Name = "tUserNameTextEdit";
            this.tUserNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tUserNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.tUserNameTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tUserNameTextEdit.Properties.AutoHeight = false;
            this.tUserNameTextEdit.Properties.ValidateOnEnterKey = true;
            this.tUserNameTextEdit.Size = new System.Drawing.Size(361, 40);
            this.tUserNameTextEdit.StyleController = this.LoginDataControl;
            this.tUserNameTextEdit.TabIndex = 4;
            this.tUserNameTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tUserNameTextEdit_KeyDown);
            // 
            // loginViewModelBindingSource
            // 
            this.loginViewModelBindingSource.DataSource = typeof(RAMSDB_WinForms.ViewModels.LoginViewModel.LoginViewModel);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(385, 64);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFortUserName});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(365, 44);
            // 
            // ItemFortUserName
            // 
            this.ItemFortUserName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemFortUserName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemFortUserName.Control = this.tUserNameTextEdit;
            this.ItemFortUserName.Location = new System.Drawing.Point(0, 0);
            this.ItemFortUserName.MinSize = new System.Drawing.Size(66, 38);
            this.ItemFortUserName.Name = "ItemFortUserName";
            this.ItemFortUserName.Size = new System.Drawing.Size(365, 44);
            this.ItemFortUserName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemFortUserName.Text = "User Name";
            this.ItemFortUserName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemFortUserName.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version 1.3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oromia RRA";
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginDataControl);
            this.Controls.Add(this.LoginButton);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginDataControl)).EndInit();
            this.LoginDataControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tUserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton LoginButton;
        private DevExpress.XtraDataLayout.DataLayoutControl LoginDataControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource loginViewModelBindingSource;
        private DevExpress.XtraEditors.TextEdit tUserNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
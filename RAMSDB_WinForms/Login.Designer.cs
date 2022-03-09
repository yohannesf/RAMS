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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFortUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginDataControl)).BeginInit();
            this.LoginDataControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LoginButton.Appearance.Options.UseFont = true;
            this.LoginButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginButton.ImageOptions.SvgImage")));
            this.LoginButton.Location = new System.Drawing.Point(180, 297);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.LoginButton.Size = new System.Drawing.Size(191, 62);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginDataControl
            // 
            this.LoginDataControl.Controls.Add(this.tUserNameTextEdit);
            this.LoginDataControl.DataSource = this.loginViewModelBindingSource;
            this.LoginDataControl.Location = new System.Drawing.Point(100, 138);
            this.LoginDataControl.Name = "LoginDataControl";
            this.LoginDataControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(546, 0, 812, 500);
            this.LoginDataControl.Root = this.layoutControlGroup1;
            this.LoginDataControl.Size = new System.Drawing.Size(385, 129);
            this.LoginDataControl.TabIndex = 5;
            this.LoginDataControl.Text = "dataLayoutControl1";
            // 
            // tUserNameTextEdit
            // 
            this.tUserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginViewModelBindingSource, "tUserName", true));
            this.tUserNameTextEdit.Location = new System.Drawing.Point(106, 12);
            this.tUserNameTextEdit.Name = "tUserNameTextEdit";
            this.tUserNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tUserNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.tUserNameTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tUserNameTextEdit.Properties.AutoHeight = false;
            this.tUserNameTextEdit.Properties.ValidateOnEnterKey = true;
            this.tUserNameTextEdit.Size = new System.Drawing.Size(267, 105);
            this.tUserNameTextEdit.StyleController = this.LoginDataControl;
            this.tUserNameTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(385, 129);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(365, 109);
            // 
            // ItemFortUserName
            // 
            this.ItemFortUserName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemFortUserName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemFortUserName.Control = this.tUserNameTextEdit;
            this.ItemFortUserName.Location = new System.Drawing.Point(0, 0);
            this.ItemFortUserName.Name = "ItemFortUserName";
            this.ItemFortUserName.Size = new System.Drawing.Size(365, 109);
            this.ItemFortUserName.Text = "User Name";
            this.ItemFortUserName.TextSize = new System.Drawing.Size(82, 18);
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
            // loginViewModelBindingSource
            // 
            this.loginViewModelBindingSource.DataSource = typeof(RAMSDB_WinForms.ViewModels.LoginViewModel.LoginViewModel);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 481);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).EndInit();
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
    }
}
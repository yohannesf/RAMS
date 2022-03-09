namespace RAMSDB_WinForms.PPP
{
    partial class Form1
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
            this.ccB = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ccB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ccB
            // 
            this.ccB.EditValue = "";
            this.ccB.Location = new System.Drawing.Point(432, 96);
            this.ccB.Name = "ccB";
            this.ccB.Properties.AllowMultiSelect = true;
            this.ccB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)});
            this.ccB.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
            this.ccB.Properties.ForceUpdateEditValue = DevExpress.Utils.DefaultBoolean.False;
            this.ccB.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "One"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Two"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Three")});
            this.ccB.Properties.SynchronizeEditValueWithCheckedItems = false;
            this.ccB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ccB.Size = new System.Drawing.Size(301, 22);
            this.ccB.TabIndex = 0;
            this.ccB.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ccB_ButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(432, 299);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(125, 22);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 538);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ccB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ccB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccB;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}
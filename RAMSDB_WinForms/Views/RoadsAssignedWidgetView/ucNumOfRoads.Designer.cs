namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    partial class ucNumOfRoads
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumOfRoads = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumOfRoads
            // 
            this.lblNumOfRoads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfRoads.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfRoads.Location = new System.Drawing.Point(0, 0);
            this.lblNumOfRoads.Name = "lblNumOfRoads";
            this.lblNumOfRoads.Size = new System.Drawing.Size(213, 197);
            this.lblNumOfRoads.TabIndex = 0;
            this.lblNumOfRoads.Text = "label1";
            this.lblNumOfRoads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucNumOfRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumOfRoads);
            this.Name = "ucNumOfRoads";
            this.Size = new System.Drawing.Size(213, 197);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfRoads;
    }
}

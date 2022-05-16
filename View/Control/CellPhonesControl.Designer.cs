namespace WinFormsPractice.View
{
    partial class CellPhonesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellPhonesControl));
            this.cellPhonesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cellPhonesLabel
            // 
            resources.ApplyResources(this.cellPhonesLabel, "cellPhonesLabel");
            this.cellPhonesLabel.Name = "cellPhonesLabel";
            // 
            // CellPhonesControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cellPhonesLabel);
            this.Name = "CellPhonesControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cellPhonesLabel;
    }
}

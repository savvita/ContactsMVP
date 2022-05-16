namespace WinFormsPractice.View
{
    partial class NameControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameControl));
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            // 
            // secondNameTextBox
            // 
            resources.ApplyResources(this.secondNameTextBox, "secondNameTextBox");
            this.secondNameTextBox.Name = "secondNameTextBox";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // secondNameLabel
            // 
            resources.ApplyResources(this.secondNameLabel, "secondNameLabel");
            this.secondNameLabel.Name = "secondNameLabel";
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // NameControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "NameControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}

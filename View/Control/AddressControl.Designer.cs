namespace WinFormsPractice.View
{
    partial class AddressControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressControl));
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.appartmentLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.appartmentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // cityLabel
            // 
            resources.ApplyResources(this.cityLabel, "cityLabel");
            this.cityLabel.Name = "cityLabel";
            // 
            // countryLabel
            // 
            resources.ApplyResources(this.countryLabel, "countryLabel");
            this.countryLabel.Name = "countryLabel";
            // 
            // streetLabel
            // 
            resources.ApplyResources(this.streetLabel, "streetLabel");
            this.streetLabel.Name = "streetLabel";
            // 
            // houseLabel
            // 
            resources.ApplyResources(this.houseLabel, "houseLabel");
            this.houseLabel.Name = "houseLabel";
            // 
            // appartmentLabel
            // 
            resources.ApplyResources(this.appartmentLabel, "appartmentLabel");
            this.appartmentLabel.Name = "appartmentLabel";
            // 
            // countryTextBox
            // 
            resources.ApplyResources(this.countryTextBox, "countryTextBox");
            this.countryTextBox.Name = "countryTextBox";
            // 
            // cityTextBox
            // 
            resources.ApplyResources(this.cityTextBox, "cityTextBox");
            this.cityTextBox.Name = "cityTextBox";
            // 
            // streetTextBox
            // 
            resources.ApplyResources(this.streetTextBox, "streetTextBox");
            this.streetTextBox.Name = "streetTextBox";
            // 
            // houseTextBox
            // 
            resources.ApplyResources(this.houseTextBox, "houseTextBox");
            this.houseTextBox.Name = "houseTextBox";
            // 
            // appartmentTextBox
            // 
            resources.ApplyResources(this.appartmentTextBox, "appartmentTextBox");
            this.appartmentTextBox.Name = "appartmentTextBox";
            // 
            // AddressControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appartmentTextBox);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.appartmentLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Name = "AddressControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label appartmentLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox appartmentTextBox;
    }
}

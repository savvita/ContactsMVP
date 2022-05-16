namespace WinFormsPractice.View
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.yourContactsLabel = new System.Windows.Forms.Label();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yourContactsLabel
            // 
            resources.ApplyResources(this.yourContactsLabel, "yourContactsLabel");
            this.yourContactsLabel.Name = "yourContactsLabel";
            // 
            // contactsListBox
            // 
            resources.ApplyResources(this.contactsListBox, "contactsListBox");
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // addContactButton
            // 
            resources.ApplyResources(this.addContactButton, "addContactButton");
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.Name = "editButton";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // viewButton
            // 
            resources.ApplyResources(this.viewButton, "viewButton");
            this.viewButton.Name = "viewButton";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ContactsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.contactsListBox);
            this.Controls.Add(this.yourContactsLabel);
            this.Name = "ContactsForm";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourContactsLabel;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
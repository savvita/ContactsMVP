using System;
using System.Windows.Forms;

namespace WinFormsPractice.View
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();

            this.contactControl = new ContactControl();
            this.contactControl.Location = new System.Drawing.Point(13, 13);
            this.contactControl.Name = "contactControl1";
            this.contactControl.Size = new System.Drawing.Size(736, 341);
            this.contactControl.TabIndex = 0;
            this.Controls.Add(this.contactControl);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            (this.Owner as ContactsForm).NewContact = this.contactControl.GetContact();

            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        public EditContactForm(Contact contact) : this()
        {
            // 
            // contactControl1
            // 
            this.contactControl = new ContactControl(contact, false);
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            (this.Owner as ContactsForm).NewContact = this.contactControl.GetContact();
            this.Close();
        }
    }
}

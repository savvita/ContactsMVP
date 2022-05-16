using System;
using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class ViewContactForm : Form
    {
        public ViewContactForm()
        {
            InitializeComponent();
        }

        public ViewContactForm(Contact contact) : this()
        {
            this.contactControl = new ContactControl(contact, true);
            this.contactControl.Location = new System.Drawing.Point(12, 12);
            this.contactControl.Name = "contactControl";
            this.contactControl.Size = new System.Drawing.Size(736, 341);
            this.contactControl.TabIndex = 0;
            this.Controls.Add(this.contactControl);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

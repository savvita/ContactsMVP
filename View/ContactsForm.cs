using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class ContactsForm : Form, IContacts
    {
        List<Contact> contacts;
        BindingSource bindingSource;

        public Contact NewContact { get; set; }

        public ContactsForm()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = contacts;

            this.contactsListBox.DataSource = bindingSource;
            this.contactsListBox.DisplayMember = "Name";
            this.contactsListBox.ValueMember = "Name";
            this.contactsListBox.DoubleClick += ContactsListBox_DoubleClick;

            this.NewContact = new Contact();
        }

        public event EventHandler LoadEventHandler;
        public event EventHandler AddEventHandler;
        public event EventHandler EditEventHandler;
        public event EventHandler DeleteEventHandler;

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            if (LoadEventHandler != null)
                LoadEventHandler(this, EventArgs.Empty);
        }

        public void SetContacts(List<Contact> contacts)
        {
            this.contacts.Clear();
            this.contacts.AddRange(contacts);
            this.bindingSource.ResetBindings(false);

            if (this.contacts.Count > 0)
            {
                SetContactImage(this.contacts[this.contactsListBox.SelectedIndex]);
                this.nameTextBox.Text = this.contactsListBox.SelectedValue.ToString();
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if(this.contactsListBox.SelectedValue != null)
                new ViewContactForm(contacts[this.contactsListBox.SelectedIndex]).ShowDialog();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nameTextBox.Text = this.contactsListBox.SelectedValue.ToString();

            SetContactImage(this.contacts[this.contactsListBox.SelectedIndex]);
        }

        public void ContactsListBox_DoubleClick(object sender, EventArgs e)
        {
            ViewButton_Click(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(new AddContactForm().ShowDialog(this) == DialogResult.OK)
            {
                if (AddEventHandler != null)
                    AddEventHandler(this, EventArgs.Empty);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.contactsListBox.SelectedValue != null)
            {
                if (new EditContactForm(contacts[this.contactsListBox.SelectedIndex]).ShowDialog(this) == DialogResult.OK)
                {
                    this.NewContact.ID = contacts[this.contactsListBox.SelectedIndex].ID;

                    if (EditEventHandler != null)
                        EditEventHandler(this, EventArgs.Empty);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.contactsListBox.SelectedValue != null)
            {
                if (MessageBox.Show($"Delete contact \"{this.contactsListBox.SelectedValue.ToString()} \"? ", "Contacts",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.NewContact.ID = contacts[this.contactsListBox.SelectedIndex].ID;
                    this.pictureBox.Image = Properties.Resources.NoPhoto;

                    if (DeleteEventHandler != null)
                        DeleteEventHandler(this, EventArgs.Empty);
                }
            }
        }

        private void SetContactImage(Contact contact)
        {
            if (File.Exists(contact.ImageFile))
            {
                this.pictureBox.Image = Image.FromFile(contact.ImageFile);
            }
            else
            {
                this.pictureBox.Image = Properties.Resources.NoPhoto;
            }
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}

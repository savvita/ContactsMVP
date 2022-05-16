using System;
using WinFormsPractice.DataBaseProcessing;
using WinFormsPractice.View;
using System.Windows.Forms;

namespace WinFormsPractice.Presenter
{
    public class MainPresenter
    {
        IDatabaseManager manager;
        IContacts contactsView;

        public MainPresenter(IDatabaseManager manager, IContacts contacts)
        {
            this.manager = manager;
            this.contactsView = contacts;

            this.contactsView.LoadEventHandler += ContactsView_LoadEventHandler;
            this.contactsView.AddEventHandler += ContactsView_AddEventHandler;
            this.contactsView.EditEventHandler += ContactsView_EditEventHandler;
            this.contactsView.DeleteEventHandler += ContactsView_DeleteEventHandler;
        }

        private void ContactsView_DeleteEventHandler(object sender, EventArgs e)
        {
            try
            {
                var contacts = manager.GetContacts();
                manager.RemoveContact(contacts, contactsView.NewContact);
                contactsView.SetContacts(contacts);
                manager.SaveToFile(contacts);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactsView_EditEventHandler(object sender, EventArgs e)
        {
            try
            {
                var contacts = manager.GetContacts();
                contacts.Find(x => x.ID == contactsView.NewContact.ID).SetNewValue(contactsView.NewContact);
                contactsView.SetContacts(contacts);
                manager.SaveToFile(contacts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactsView_AddEventHandler(object sender, EventArgs e)
        {
            try
            {
                var contact = manager.CreateContact(contactsView.NewContact);
                var contacts = manager.GetContacts();
                contacts.Add(contact);
                contactsView.SetContacts(contacts);
                manager.SaveToFile(contacts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactsView_LoadEventHandler(object sender, EventArgs e)
        {
            try
            {
                var contacts = manager.GetContacts();
                contactsView.SetContacts(contacts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System.Collections.Generic;
using WinFormsPractice.Model;

namespace WinFormsPractice.DataBaseProcessing
{
    public interface IDatabaseManager
    {
        List<Contact> GetContacts();
        Contact CreateContact(Contact contact);
        void SaveToFile(List<Contact> contacts);
        void RemoveContact(List<Contact> contacts, Contact contact);
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WinFormsPractice.Model;

namespace WinFormsPractice.DataBaseProcessing
{
    public class DatabaseManager : IDatabaseManager
    {
        private string contactsFileName = "contacts.csv".FullPath();

        public List<Contact> GetContacts()
        {
            return contactsFileName.LoadFromFile().ConvertToContacts();
        }

        public Contact CreateContact(Contact contact)
        {
            List<Contact> contacts = GetContacts();

            int currentId = 1;

            if(contacts.Count > 0)
            {
                currentId = contacts.OrderByDescending(x => x.ID).First().ID + 1;
            }

            contact.ID = currentId;

            return contact;
        }

        public void SaveToFile(List<Contact> contacts)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Contact contact in contacts)
            {
                sb.Append($"{contact.ID},{contact.Name.FirstName},{contact.Name.SecondName},{contact.Name.LastName},");
                sb.Append($"{contact.HomeAddress.Country},{contact.HomeAddress.City}," +
                    $"{contact.HomeAddress.Street},{contact.HomeAddress.House},{contact.HomeAddress.Appartment},");
                sb.Append($"{ contact.ImageFile },");

                foreach (string cellphone in contact.Numbers.Numbers)
                {
                    sb.Append($"{ cellphone },");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            File.WriteAllText(contactsFileName, sb.ToString());
        }

        public void RemoveContact(List<Contact> contacts, Contact contact)
        {
            contacts.Remove(contacts.Find(x => x.ID == contact.ID));

            if (File.Exists(contact.ImageFile))
            {
                try
                {
                    File.Delete(contact.ImageFile);
                }
                catch
                {
                }
            }
        }
    }
}

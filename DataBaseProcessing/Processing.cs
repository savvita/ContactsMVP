using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinFormsPractice.Model;

namespace WinFormsPractice.DataBaseProcessing
{
    public static class Processing
    {
        public static string FullPath(this string fileName)
        {
            return Path.Combine(Settings.FilePath, fileName);
        }

        public static List<string> LoadFromFile(this string fileName)
        {
            if(!File.Exists(fileName))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fileName).ToList();
        }

        public static List<Contact> ConvertToContacts(this List<string> lines)
        {
            List<Contact> contacts = new List<Contact>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                Contact contact = new Contact();

                int i = 0;
                
                contact.ID = int.Parse(cols[i++]);

                contact.Name.FirstName = cols[i++];
                contact.Name.SecondName = cols[i++];
                contact.Name.LastName = cols[i++];

                contact.HomeAddress.Country = cols[i++];
                contact.HomeAddress.City = cols[i++];
                contact.HomeAddress.Street = cols[i++];
                contact.HomeAddress.House = cols[i++];
                contact.HomeAddress.Appartment = cols[i++];

                contact.ImageFile = cols[i++];

                for (int j = i; j < cols.Length; j++)
                {
                    contact.Numbers.Add(cols[j]);
                }

                contacts.Add(contact);
            }
            return contacts;
        }

        public static void SetNewValue(this Contact contact, Contact newContact)
        {
            contact.Name = newContact.Name;
            contact.HomeAddress = newContact.HomeAddress;
            contact.Numbers = newContact.Numbers;
            contact.ImageFile = newContact.ImageFile;
        }
        
    }
}

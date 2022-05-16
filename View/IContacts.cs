using System;
using System.Collections.Generic;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public interface IContacts
    {
        Contact NewContact { get; set; }
        void SetContacts(List<Contact> contacts);
        event EventHandler LoadEventHandler;
        event EventHandler AddEventHandler;
        event EventHandler EditEventHandler;
        event EventHandler DeleteEventHandler;
    }
}

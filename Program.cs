using System;
using System.Windows.Forms;
using WinFormsPractice.View;
using WinFormsPractice.DataBaseProcessing;
using WinFormsPractice.Presenter;
using System.IO;

namespace WinFormsPractice
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings.FilePath = @"d:\contacts";

            if(!Directory.Exists(Settings.FilePath))
                Directory.CreateDirectory(Settings.FilePath);

            Settings.MaxCellphoneNumber = 5;

            ContactsForm form = new ContactsForm();
            DatabaseManager databaseManager = new DatabaseManager();
            MainPresenter presenter = new MainPresenter(databaseManager, form);

            Application.Run(form);
        }
    }
}

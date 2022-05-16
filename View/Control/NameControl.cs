using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class NameControl : UserControl
    {
        public NameControl()
        {
            InitializeComponent();
        }

        public NameControl(FullName name) : this()
        {
            this.firstNameTextBox.Text = name.FirstName;
            this.secondNameTextBox.Text = name.SecondName;
            this.lastNameTextBox.Text = name.LastName;
        }


        public FullName GetFullName()
        {
            return new FullName 
            { 
                FirstName = this.firstNameTextBox.Text, 
                SecondName = this.secondNameTextBox.Text, 
                LastName = this.lastNameTextBox.Text 
            };
        }
    }
}

using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }
        public AddressControl(Address address) : this()
        {
            SetAddress(address);
        }

        public void SetAddress(Address address)
        {
            this.countryTextBox.Text = address.Country;
            this.cityTextBox.Text = address.City;
            this.streetTextBox.Text = address.Street;
            this.houseTextBox.Text = address.House;
        }

        public Address GetAddress()
        {
            return new Address
            {
                Country = this.countryTextBox.Text,
                City = this.cityTextBox.Text,
                Street = this.streetTextBox.Text,
                House = this.houseTextBox.Text,
                Appartment = this.appartmentTextBox.Text
            };
        }
    }
}

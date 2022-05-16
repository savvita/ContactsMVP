namespace WinFormsPractice.Model
{
    public class Contact
    {
        public int ID { get; set; }
        public FullName Name { get; set; }
        public Cellphones Numbers{ get; set; }
        public Address HomeAddress{ get; set; }

        public string ImageFile { get; set; }

        public Contact()
        {
            Numbers = new Cellphones();
            Name = new FullName();
            HomeAddress = new Address();
        }
    }
}

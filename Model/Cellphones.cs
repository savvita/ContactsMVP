using System.Collections.Generic;


namespace WinFormsPractice.Model
{
    public class Cellphones
    {
        public List<string> Numbers { get; set; }
        public Cellphones()
        {
            Numbers = new List<string>();
        }

        public void Add(string number)
        {
            this.Numbers.Add(number);
        }
    }
}

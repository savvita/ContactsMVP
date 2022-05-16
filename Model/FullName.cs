namespace WinFormsPractice.Model
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{ FirstName } { SecondName } { LastName }";
        }
    }
}

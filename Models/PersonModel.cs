namespace persons_api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
    }
}
namespace RaceProject.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Ranking { get; set; }

        
    }
}

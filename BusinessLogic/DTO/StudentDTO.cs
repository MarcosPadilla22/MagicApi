namespace BusinessLogic.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Identification { get; set; }
        public short Age { get; set; }
        public int IdAffinity { get; set; }

        public string TypeStatus { get; set; }
        public string? AffinityName { get; set; }
        public string? GrimoireName { get; set; }
    }
}

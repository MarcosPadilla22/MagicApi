namespace DataAccess.Models
{
    public class Grimoire
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Student Student { get; set; }
    }
}

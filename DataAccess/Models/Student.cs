namespace DataAccess.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Identification { get; set; }
        public short Age { get; set; }
        public int IdAffinity { get; set; }
        public int IdGrimoire { get; set; }
        public DateTime CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }


        public virtual Grimoire Grimoire { get; set; }
        public virtual Affinity Affinity { get; set; }
    }
}

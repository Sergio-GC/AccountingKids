using System.ComponentModel.DataAnnotations;

namespace AccountingKids.Entities
{
    public class Kid
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Birthdate { get; set; }


        public virtual ICollection<Kid>? Siblings { get; set; }
    }
}

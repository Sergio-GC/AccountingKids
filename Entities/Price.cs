using System.ComponentModel.DataAnnotations;

namespace AccountingKids.Entities
{
    public class Price
    {
        [Key]
        public int Id {  get; set; }
        public string Label { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

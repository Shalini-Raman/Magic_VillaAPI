using System.ComponentModel.DataAnnotations;

namespace Magic_VillaAPI.Models.Dto
{
    public class VillaDto
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int Occupancy { get; set; }
        public int Sqft { get; set; }
    }
}

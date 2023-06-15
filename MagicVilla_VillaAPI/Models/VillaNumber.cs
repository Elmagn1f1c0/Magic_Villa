using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set;}

        //Added this because the relationship is one to many meaning one Villa can have many numbers

        [ForeignKey("Villa")]
        public int VillaID { get; set; }

        public Villa Villa { get; set; }
    }
}

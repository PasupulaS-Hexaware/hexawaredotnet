
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hexawware.Entities.Entities
{
    public class Hexaware
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id  { get; set; }
        public string hesxawaredotnet  { get; set; }
        
    }

}

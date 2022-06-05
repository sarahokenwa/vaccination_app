using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vaccination_app.VaccinationDB
{
   
    [Table("Hospital")]
    public class Hospital
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Hospital_Id { get; set; }
        public string Hospital_Name { get; set; }
        public string Hospital_Location { get; set; }
        public string State { get; set; }
    }
}

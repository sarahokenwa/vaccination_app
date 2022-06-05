using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vaccination_app.VaccinationDB
{
    [Table("Vaccination")]
    public class Vaccination
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Vaccination_Id { get; set; }
        public int Child_Id { get; set; }
        public int Staff_Id { get; set; }
        public int Vaccine_Id { get; set; }
        public int Hospital_Id { get; set; }
        public string ROA { get; set; }
    }
}

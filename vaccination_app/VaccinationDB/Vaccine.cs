using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vaccination_app.VaccinationDB
{
    [Table("Vaccine")]
    public class Vaccine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Vaccine_Id { get; set; }
        public string Vaccine_Name { get; set; }
        public string Vaccine_Dose { get; set; }
        public int Child_Age { get; set; }
        public string Disease_Prevention { get; set; }
        public string ROA { get; set; }
        public string Vaccination_Site { get; set; }
    }
}

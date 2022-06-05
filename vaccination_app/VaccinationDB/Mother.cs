using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vaccination_app.VaccinationDB
{
    [Table("Mother")]
    public class Mother
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Mother_Id { get; set; }
        public int Child_Id { get; set; }
        public string Mother_Name { get; set; }
        public string Mother_Location { get; set; }
        
    }
}

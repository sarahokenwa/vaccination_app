using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vaccination_app.VaccinationDB
{
        [Table("Staff")]
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Staff_Id { get; set; }
        public string Staff_FirstName { get; set; }
        public string Staff_LastName { get; set; }
        public string Staff_Role { get; set; }
       
    }
}

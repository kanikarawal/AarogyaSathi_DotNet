using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AarogyaSaathi.Models
{
    public class Patient 
    {
       
        public int Id { get; set; }

        //public int DoctorId { get; set; }

        //public DateTime date { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public long MobileNo { get; set; }
        public string email { get; set; }
        public string Password { get; set; }




    }
}

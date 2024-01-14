using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AarogyaSaathi.Models
{
    public class Doctor
    {
       
        public int Id { get; set; } 
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Qualification { get; set; }

        public string Specialization { get; set; }  
    }
}

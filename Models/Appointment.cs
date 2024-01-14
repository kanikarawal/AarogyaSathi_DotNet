namespace AarogyaSaathi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string DoctorId {  get; set; }
        
        public string Symptoms {  get; set; }
        public DateTime? BookingDate { get; set; }
        public string Status { get; set; }
        public string PatientId {  get; set; }
    }
}

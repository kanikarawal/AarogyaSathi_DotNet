namespace AarogyaSaathi.Models
{
    public class PatientHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime visitDate { get; set; }
        public string doctorName { get; set; }
        public string symptoms { get; set; }
        public string medicine { get; set; }
        public string remark { get; set; }
       // public string PatientId { get; set; }
    }
}

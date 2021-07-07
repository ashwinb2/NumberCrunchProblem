namespace API.Models
{
    public class SampleScoresRequest
    {
        public int SampleMaxCount { get; set; }
        public int PatientScore { get; set; }
        public int DoctorScore { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
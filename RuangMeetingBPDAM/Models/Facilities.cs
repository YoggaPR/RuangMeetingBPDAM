using System.ComponentModel.DataAnnotations;

namespace RuangMeetingBPDAM.Models
{
    public class Facilities
    {
        [Key]
        public int Id { get; set; }
        public string PIN { get; set; }
        public int Participants { get; set; }
        public string Facility { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Title { get; set; }
        public string Tower { get; set; }
        public string Floor { get; set; }
        public string PIC { get; set; }
        public string Email { get; set; }
    }
}

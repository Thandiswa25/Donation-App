using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class DisasDon
    {
        [Key]
        public int DisasterId { get; set; }
        public DateTime StartDisasterDate { get; set; }

        public DateTime EndDisasterDate { get; set; }

        public string location { get; set; }

        public string DisasterName { get; set; }


        public string DisasterType { get; set; }
    }
}

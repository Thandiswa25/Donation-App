using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class monAlloc
    {
        [Key]

        public int MoneyAllocationID { get; set; }




        [ForeignKey("DisasterType")]
        public string DisasterType { get; set; }

        [ForeignKey("Disastername")]
        public string DisasterName { get; set; }





        [ForeignKey("Money")]
        public int Amount { get; set; }

        public DateTime AllocationDate { get; set; }

        public monDon? monDon { get; set; }
        public DisasDon? DisasDon { get; set; }
    }
}

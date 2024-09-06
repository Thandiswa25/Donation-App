using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class goodAlloc
    {
        [Key]
        public int GoodsAllocationId { get; set; }


        [ForeignKey("DisasterDon")]
        public string DisasterName { get; set; }
        [ForeignKey("goodtype")]
        public string GoodType { get; set; }



        public int Quantity { get; set; }
        public DateTime AllocationDate { get; set; }

        public monDon? monDon { get; set; }
        public DisasDon? DisasDon { get; set; }
    }
}

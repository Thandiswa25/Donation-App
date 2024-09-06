using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class purchas
    {
        [Key]
        public int PurchaseId { get; set; }

        public int GoodsID { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int PurchaseAmount { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class GoodDon
    {

        [Key]
        public int GoodsID { get; set; }
        public string GoodsName { get; set; }
        public string Description { get; set; }

        public string GoodType { get; set; }

        public int Numofitems { get; set; }

        public DateTime Date { get; set; }
    }
}

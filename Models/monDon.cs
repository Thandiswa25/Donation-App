using System.ComponentModel.DataAnnotations;

namespace APPR.Models
{
    public class monDon
    {
        [Key]
        public int MoneyID { get; set; }


        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

    }
}

using APPR.Data;
using Microsoft.EntityFrameworkCore;

namespace APPR.MergeDonation
{
    public class MergeDon
    {
        private readonly APPRContext _context;

        public MergeDon(APPRContext context)
        {
            _context = context;
        }

        public async Task<int> FinalCalculations()
        {
            var FinalMonetaryDonation = await _context.monDon.SumAsync(d => d.Amount);
            var totalPurchaseCapturing = await _context.purchas.SumAsync(p => p.PurchaseAmount);

            var finalCals = FinalMonetaryDonation - totalPurchaseCapturing;

            return (int)finalCals;
        }
        public async Task<int> FinalGoodsCalculations()
        {
            var FinalGoodDonation = await _context.GoodDon.SumAsync(d => d.Numofitems);
            
            return (int)FinalGoodDonation;
        }
    }
}

using Monopoly.Entities;

namespace Monopoly
{
    public class PalletServices
    {
        private readonly ApplicationDbContext _context;
        public List<Pallet> Pallets => _context.Pallets;
        public PalletServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<IGrouping<DateOnly, Pallet>> GroupByExpirationDate()
        {
            var palletGroups = _context.Pallets.GroupBy(x => x.ExpirationDate);
            return palletGroups;
        }
        public IEnumerable<Pallet> SortByExpirationDate()
        {
            var palletSorted = _context.Pallets.OrderBy(p => p.ExpirationDate);
            return palletSorted;
        }
    }
}

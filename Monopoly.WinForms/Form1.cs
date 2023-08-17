namespace Monopoly.WinForms
{
    public partial class Form1 : Form
    {
        private ApplicationDbContext _context;
        private PalletServices _palletServices;
        public Form1()
        {
            _context = new ApplicationDbContext();
            _palletServices = new PalletServices(_context);
            InitializeComponent();
        }

        private void btnLoadTestDate_Click(object sender, EventArgs e)
        {
            _context.LoadDate();
            LBPallet.Items.Clear();
            foreach (var pallet in _palletServices.Pallets)
            {
                LBPallet.Items.Add(pallet.ToString());
            }
        }

        private void btnGroupByExpiryDate_Click(object sender, EventArgs e)
        {
            LBPallet.Items.Clear();
            var groupedByExpiryDate = _palletServices.GroupByExpirationDate();

            foreach (var group in groupedByExpiryDate)
            {
                LBPallet.Items.Add($"Срок годности: {group.Key}");
                foreach (var pallet in group)
                {
                    LBPallet.Items.Add($"\tPallet ID: {pallet.ID}");
                    LBPallet.Items.Add($"\t\tBoxs: {pallet.ID}");
                    foreach (var box in pallet.Boxes)
                    {
                        LBPallet.Items.Add($"\t\tBox ID: {box.ID}");
                    }
                }
            }
        }

        private void btnSortByExpirationDate_Click(object sender, EventArgs e)
        {
            LBPallet.Items.Clear();
            var palletsSort = _palletServices.SortByExpirationDate();
            foreach (var pallet in palletsSort)
            {
                LBPallet.Items.Add(pallet.ToString());
            }
        }

        private void btnSortedGroupsByWeight_Click(object sender, EventArgs e)
        {
            LBPallet.Items.Clear();
            var groupedByExpiryDate = _palletServices.GroupByExpirationDate();

            foreach (var group in groupedByExpiryDate)
            {
                LBPallet.Items.Add($"Срок годности: {group.Key}");
                foreach (var pallet in group.OrderBy(p => p.Weight))
                {
                    LBPallet.Items.Add($"\tPallet ID: {pallet.ID}");
                    LBPallet.Items.Add($"\tВес: {pallet.Weight}");
                }
            }
        }

        private void btnPalletMaxExpiryDateSortWigth_Click(object sender, EventArgs e)
        {
            LBPallet.Items.Clear();
            var pallets = _palletServices.Pallets.OrderByDescending(p => p.ExpirationDate).Take(3).OrderBy(p => p.Weight);
            foreach (var pallet in pallets)
            {
                LBPallet.Items.Add(pallet.ToString());
            }
        }
    }
}
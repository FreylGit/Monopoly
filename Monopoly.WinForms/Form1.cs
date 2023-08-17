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
            foreach (var item in _palletServices.Pallets)
            {
                LBPallet.Items.Add(item.ToString());
            }
        }
    }
}
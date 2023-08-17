namespace Monopoly.Test
{
    [TestClass]
    public class PalletServicesTests
    {
        private ApplicationDbContext _context;
        private PalletServices _palletServices;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new ApplicationDbContext();
            _context.LoadDate(); // Загрузка тестовых данных

            _palletServices = new PalletServices(_context);
        }

        [TestMethod]
        public void GroupByExpirationDate_ShouldGroupPalletsByExpirationDate()
        {
            var result = _palletServices.GroupByExpirationDate();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SortByExpirationDate_ShouldSortPalletsByExpirationDate()
        {
            var result = _palletServices.SortByExpirationDate();

            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context = null;
            _palletServices = null;
        }
    }
}

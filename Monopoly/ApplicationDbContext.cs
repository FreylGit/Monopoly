using Monopoly.Entities;

namespace Monopoly
{
    public class ApplicationDbContext
    {
        public List<Pallet> Pallets { get; set; }
        public ApplicationDbContext()
        {
            Pallets = new List<Pallet>();
        }

        public void LoadDate()
        {
            int idBox = 1;
            int idPallet = 1;
            for (int i = 0; i < 10; i++)
            {
                Pallets.Add(new Pallet(idPallet, i + 5, 1, i + 5));
                idPallet++;
                var w = Pallets[i].Width;
                var d = Pallets[i].Depth;
                var random = new Random();

                for (int j = 1; j < 5; j++)
                {
                    // Дата и веса такие, чтобы можно было легко сгрупперовать 
                    Pallets[i].AddBox(new Box(idBox, w, j, d, random.Next(1, 5), new DateOnly(2023, random.Next(1, 3), random.Next(1, 3))));
                    idBox++;
                }
            }
        }
    }
}

namespace Monopoly.Entities
{
    public abstract class EntityBase
    {
        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public virtual double Weight { get; set; }
        public EntityBase(int iD, double width, double height, double depth, double weight)
        {
            ID = iD;
            Width = width;
            Height = height;
            Depth = depth;
            Weight = weight;
        }
        public abstract double CalculationVolume();
        public override string ToString()
        {
            return $"ID:{ID}\n Ширира:{Width}\n Высота:{Height}\n Глубина:{Depth}\n Вес:{Weight}\n";
        }

    }
}

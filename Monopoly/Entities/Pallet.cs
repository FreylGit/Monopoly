namespace Monopoly.Entities
{
    public class Pallet : EntityBase
    {
        public List<Box> Boxes { get => _boxes; }
        private List<Box> _boxes;
        private double _weight = 30;

        public Pallet(int Id, double width, double height, double depth) : base(Id, width, height, depth, 30)
        {
            _boxes = new List<Box>();
        }

        public override double Weight { get => _weight + _boxes.Select(x => x.Weight).Sum(); }
        public DateOnly ExpirationDate { get => _boxes.Select(x => x.ExpirationDate).Min(); }

        public override double CalculationVolume()
        {
            double v = Width * Depth;
            foreach (var box in _boxes)
            {
                v += box.CalculationVolume();
            }
            return v;
        }
        public void AddBox(Box box)
        {
            if (box.Width > Width || box.Depth > Depth)
            {
                throw new InvalidOperationException("Объем коробки превышает объем паллета");
            }
            _boxes.Add(box);
        }

        public override string ToString()
        {
            return base.ToString() + $"Срок годности:{ExpirationDate}\n Количество коробок: {_boxes.Count()}";
        }
    }
}

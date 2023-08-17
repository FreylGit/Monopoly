namespace Monopoly.Entities
{
    public class Box : EntityBase
    {
        private DateOnly? _createdDate;
        private DateOnly _expirationDate;

        public Box(int Id, double width, double height, double depth, double weight, DateOnly expirationDate, DateOnly? createdDate = null) : base(Id, width, height, depth, weight)
        {
            _expirationDate = expirationDate;
            _createdDate = createdDate;
        }

        public DateOnly ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public DateOnly? CreatedDate
        {
            get => _createdDate;
            set
            {
                _createdDate = value;

                if (_createdDate.HasValue)
                {
                    // Вычисляем ExpirationDate как CreatedDate + 100 дней
                    _expirationDate = _createdDate.Value.AddDays(100);
                }
            }
        }

        public override double CalculationVolume()
        {
            return Height * Width * Depth;
        }

        public override string ToString()
        {
            return base.ToString() + $"Срок годности:{ExpirationDate} \n Дата производства:{CreatedDate}";
        }
    }
}

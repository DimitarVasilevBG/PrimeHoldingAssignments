namespace NETAssignment.Cards
{
    public abstract class Card
    {
        public Owner Owner { get; private set; }
        public decimal TurnOver { get; private set; }

        private decimal initialDiscount;

        protected decimal Initial_Discount
        {
            get => initialDiscount;
            set
            {
                if (value >= 10)
                    initialDiscount = 10;
                else
                {
                    initialDiscount = value;
                }
            }
        }

        protected Card(Owner owner, decimal turnOver)
        {
            Owner = owner;
            TurnOver = turnOver;
        }

        public decimal CalculateDiscount(decimal valueOfPurchase)
        {
            if (Initial_Discount > 0)
                return valueOfPurchase * (Initial_Discount / 100);

            return Initial_Discount;
        }

        public decimal GetDiscountValue()
        {
            return this.Initial_Discount;
        }

        public decimal getTotal(decimal valueOfPurchase)
        {
            return valueOfPurchase - (valueOfPurchase * (this.Initial_Discount) / 100);
        }
    }
}
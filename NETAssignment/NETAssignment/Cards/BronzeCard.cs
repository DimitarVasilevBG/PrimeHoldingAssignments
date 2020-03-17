namespace NETAssignment.Cards
{
    public class BronzeCard : Card
    {
        public BronzeCard(Owner owner, decimal turnOver) : base(owner, turnOver)
        {
            Initial_Discount = 0.00m;

            if (TurnOver >= 100 && turnOver <= 300)
            {
                Initial_Discount = 1.00m;
            }
            else if (turnOver > 300)
            {
                Initial_Discount = 2.50m;
            }
        }
    }
}
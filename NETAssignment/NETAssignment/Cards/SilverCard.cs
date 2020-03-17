namespace NETAssignment.Cards
{
    public class SilverCard : Card
    {
        public SilverCard(Owner owner, decimal turnOver) : base(owner, turnOver)
        {
            Initial_Discount = 2.00m;

            if (turnOver > 300)
                Initial_Discount = 3.50m;
        }
    }
}
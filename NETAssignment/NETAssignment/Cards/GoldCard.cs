using System;

namespace NETAssignment.Cards
{
    public class GoldCard : Card
    {
        public GoldCard(Owner owner, decimal turnOver) : base(owner, turnOver)
        {
            Initial_Discount = 2.00m;

            if (turnOver > 0)
            {
                Initial_Discount += Math.Floor(turnOver / 100);
            }
        }
    }
}
using System;
using NETAssignment.Cards;

namespace NETAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner = new Owner("Dimitar", "Vasilev");
            var bronzeCard = new BronzeCard(owner, 0);

            var secondOwner = new Owner("Ivan", "Ivanov");
            var silverCard = new SilverCard(secondOwner, 600);

            var thirdOwner = new Owner("Desislava", "Vasileva");
            var goldCard = new GoldCard(thirdOwner, 1500);

            PayDesk.Checkout(bronzeCard, 150);
            PayDesk.Checkout(silverCard, 850);
            PayDesk.Checkout(goldCard, 1300);
        }
    }
}
using System;
using System.Text;
using NETAssignment.Cards;

namespace NETAssignment
{
    public static class PayDesk
    {
        public static void Checkout(Card card, decimal valueOfPurchase)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(card.Owner.FirstName + " " + card.Owner.LastName);
            sb.AppendLine($"Purcase value: ${valueOfPurchase:F2}");
            sb.AppendLine();
            sb.AppendLine($"Discount rate: {card.GetDiscountValue()}%");
            sb.AppendLine();
            sb.AppendLine($"Discount: ${card.CalculateDiscount(valueOfPurchase):F2}");
            sb.AppendLine();
            sb.AppendLine($"Total: ${card.getTotal(valueOfPurchase):F2}");


            Console.WriteLine(sb.ToString());
        }
    }
}
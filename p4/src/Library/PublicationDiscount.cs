using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}
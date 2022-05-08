using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
         public double TotalPrice()
        {
            double result = 0;

            foreach (PublicationItem publication in this.items)
            {
                result += publication.SubTotalPrice();
            }

            return result;
        }

        public string AsText(){
            string text = ($"Fecha {this.EndDate}:\n");
            foreach (PublicationItem publication in this.items)
            {
                text += ($"{publication.Quantity} de {publication.Price} a $ {publication.SubTotalPrice()}\n");
            }
            text += ($"Costo Total: $ {TotalPrice()}");
            return text;
        }
    }
}
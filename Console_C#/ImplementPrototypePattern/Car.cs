using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPrototypePattern
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName {  get; set; }
        public int BasePrice
        {
            set => basePrice = value;
            get => basePrice;
        }
        public int OnRoadPrice
        {
            set => onRoadPrice = value;
            get => OnRoadPrice;
        }
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(200_000, 500_000);
            return additionalPrice;
        }
        public abstract Car Clone();
    }
}

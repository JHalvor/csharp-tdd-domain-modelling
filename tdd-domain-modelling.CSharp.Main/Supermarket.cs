using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Supermarket
    {
        private Dictionary<string, int> _basket = new Dictionary<string, int>();
        public Dictionary<string, int> basket { get { return _basket; } }

        public bool Add(string product, int price)
        {
            if (basket.ContainsKey(product))
            {
                return false;
            }
            basket.Add(product, price);
            return true;
        }

        public int GetTotalPrices()
        {
            if (basket.Count == 0)
            {
                return 0;
            }
            return basket.Values.Sum(x => x);
        }
    }
}

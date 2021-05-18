using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchlistLibrary
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Date { get; set; }
        public string Category { get; set; }
        public double Score { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaanUMN
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public String Type { get; set; }
        public string Year { get; set; }
        public int Qty { get; set; }

        public bool borrowBooks()
        {
            if (Qty > 0)
            {
                Qty--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
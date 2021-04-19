using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPoint
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }

        public void AddHyperlinl(string url)
        {
            Console.WriteLine("Link Added");
        }
    }
}

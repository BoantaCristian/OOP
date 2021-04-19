using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            //var text = new PresentationObject(); // if declared like this, cannot access to Text() members such as FontSize
            text.Width = 100;
            text.FontSize = 12;
            text.Copy();
            Console.WriteLine(text.Width);
            Console.Read();
        }
    }
}

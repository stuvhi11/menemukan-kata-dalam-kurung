using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message2 = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu (program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks)";
            int openingPosition2 = message2.IndexOf('(');
            openingPosition2 += 1;
            int closingPosition2 = message2.IndexOf(')');

            int first = closingPosition2 - openingPosition2;
            int osec = message2.IndexOf('(', closingPosition2 += 1);
            int osec1 = message2.LastIndexOf(')');
            osec += 1;
            int lengtht = osec1 - osec;
            string osec2 = (message2.Substring(osec, lengtht));

            Console.WriteLine($"-{message2.Substring(openingPosition2, first)}");
            Console.WriteLine($"-{osec2}");
            while (true)
            {
                int firstt = osec2.IndexOf('(');
                if (firstt == -1) break;

                firstt += 1;
                int last = osec2.IndexOf(')');
                int lengthht = last - firstt;
                Console.WriteLine($"-{osec2.Substring(firstt, lengthht)}");
                osec2 = osec2.Substring(last + 1);
            }
        }
    }
}

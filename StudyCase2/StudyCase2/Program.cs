using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks)";
            while (true)
            {
                int openingPosition1 = message1.IndexOf('(');
                if (openingPosition1 == -1) break;

                openingPosition1 += 1;
                int closingPosition1 = message1.IndexOf(')');
                int length1 = closingPosition1 - openingPosition1;
                Console.WriteLine($"-{message1.Substring(openingPosition1, length1)}");

                message1 = message1.Substring(closingPosition1 + 1);
            }
        }
    }
}

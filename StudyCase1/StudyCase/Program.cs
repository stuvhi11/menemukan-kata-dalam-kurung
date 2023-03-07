using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks";
            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            string output = (message.Substring(openingPosition, length));
            Console.WriteLine(message);
            Console.WriteLine($"-hasil dari program :\n-{output}");
        }
    }
}

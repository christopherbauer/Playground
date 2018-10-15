using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackDavisPlayground
{
    class Program
    {
        private static void Main(string[] args)
        {
            var playerArray = new int[] {0, 1, 2, 3};
            var podsArray = new int[] {10, 10, 10, 10};
            const int humanId = 0;
            playerArray = playerArray.Where(i => i != humanId).ToArray();
            foreach (var player in playerArray)
            {
            }
//code start

            var text = "This jext has jack at index 14";
            var myName = "jack";
            var hits = new StringBuilder();

            for (var i = 0; i < text.Length; i++)
            {

                if (text.Substring(i, 1) == "j")
                {

                    for (var j = i; j < myName.Length + i; j++)
                    {
                        hits.Append(text[j]);
                    }

                }

                if (hits.Length == 0)
                {
                    //Console.WriteLine("Your name was not found");
                }
                else
                {
                    Console.WriteLine(hits);
                }
            }
//code end
        }
    }

    internal class AdjacencyZone
    {
        public int Zone1 { get; set; }
    }
}

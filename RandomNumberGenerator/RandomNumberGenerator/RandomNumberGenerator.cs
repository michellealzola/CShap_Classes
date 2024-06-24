using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    internal static class RandomNumberGenerator
    {
        private static readonly List<string> genRandomList= new List<string>();

        public static void GetRandomNumbers()
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            int size = 15;

            for (int i = 0; i < size; i++)
            {
                sb.Append(rand.Next(10).ToString());
            }

            genRandomList.Add(sb.ToString());
        }

        public static List<string> GetNumbers()
        {
            return genRandomList;
        }
    }
}

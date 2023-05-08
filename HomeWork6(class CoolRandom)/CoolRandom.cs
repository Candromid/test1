using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_class_CoolRandom_
{
    public class CoolRandom
    {
        private Random random;
        private int min;
        private int max;
        private List<int> values = new();

        public CoolRandom(int min, int max)
        {

            this.random = new Random();
            this.min = min;
            this.max = max;
       
        }

        public int Next()
        {
            if (values.Count == 0)
            {
                values = Enumerable.Range(min, max - min +1 ).ToList();
            }

            int index = random.Next(0, values.Count);
            int value = values[index];
            values.RemoveAt(index);

            return value;
        }

               
    }
}

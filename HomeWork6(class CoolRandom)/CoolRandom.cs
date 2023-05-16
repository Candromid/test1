namespace HomeWork6_class_CoolRandom_
{
    public class CoolRandom
    {
        private readonly Random random;
        private readonly int min;
        private readonly int max;
        private List<int> values = new();
        private string t;
        
        public string Name { get; set; }

        public CoolRandom(int min, int max)
        {

            random = new Random(); // переменная получающая рандомное число
            this.min = min;
            this.max = max;     // задаём максимальное значение диапозона рандома 
       
        }

        public int Next()
        {
            if (values.Count == 0)   // проверка на пустой список
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

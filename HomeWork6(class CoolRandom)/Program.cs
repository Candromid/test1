namespace HomeWork6_class_CoolRandom_
{
    public class Program
    {
        static void Main(string[] args)
        {

            CoolRandom coolRandom = new CoolRandom(-5, 5);

            for (int i = 0; i < 30; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine(" - ");
                int randomNumber = coolRandom.Next();  //переменная для хранения значения метода coolRandom
                Console.WriteLine(randomNumber);  //визуалка
            }

            

        }
    }
}
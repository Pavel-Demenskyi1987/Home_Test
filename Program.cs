namespace Tsak_01
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            Random rand = new Random();
            int count = 0;
            int size = 10;
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 101);
            }
            foreach(int item in array)
            {
                System.Console.Write(item + " ");
            }
            for (int i = 0; i < size; i++)
            {
                if (array[i] > 20 && array[i] < 90)
                {
                    count++;
                }
            }

            System.Console.WriteLine($"Количество лежащих на отрезке от 20 до 90 => {count}");

        }
    }
}

using System.Text;

namespace lab4
{
    class Program
    {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            //task 1
            {
                int[] array = new int[9];
                Random rand = new();

                Console.WriteLine("Вихідний масив: ");
                for (int i = 0; i < array.Length; i++) {
                    array[i] = rand.Next(0, 10);
                    Console.Write(array[i] + " ");
                }
                
                int result = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 6)
                        result*=array[i];
                }
                Console.WriteLine(" \nДобуток членів менше 6: " + result);
            }

            //task2
            {
                Console.WriteLine("Введіть довжину масиву:");
                int length = int.Parse(Console.ReadLine());

                int[] array = new int[length];

                Random rand = new();

                Console.WriteLine("Вихідний масив: ");
                for (int i = 0; i < array.Length; i++) {
                    int a =  rand.Next(-3, 10);
                    array[i] = a;
                    Console.Write(a + " ");
                }

                Console.WriteLine("\nОброблений масив: ");

                for (int i = 0; i < array.Length; i++) {
                    if (array[i] > 0) {
                        for (int ii = 0; ii < array.Length; ii++) {
                            if (array[i] == -array[ii]) {
                                array[ii] *= -1;
                            }
                        }
                    }
                }

                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
using System;

namespace MySortArrayProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");

            string[] Snums = Console.ReadLine().Split(new char[] { ',' });
            int[] Inums = new int[Snums.Length];

            for (int i = 0; i < Snums.Length; i++)
            {
                Inums[i] = int.Parse(Snums[i]);
            }

            Console.WriteLine("Неотсортированный массив:");
            
            foreach (int value in Inums)
            {
                Console.Write($"{value} ");
            }

            int indx; //переменная для хранения индекса минимального элемента массива
            
            for (int i = 0; i < Inums.Length; i++) //проходим по массиву с начала и до конца
            {
                indx = i; //считаем, что минимальный элемент имеет текущий индекс 
                
                for (int j = i; j < Inums.Length; j++) //ищем минимальный элемент в неотсортированной части
                {
                    if (Inums[j] < Inums[indx])
                    {
                        indx = j; //нашли в массиве число меньше, чем intArray[indx] - запоминаем его индекс в массиве
                    }
                }
                
                if (Inums[indx] == Inums[i]) //если минимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами минимальный элемент и первый в неотсортированной части
                int temp = Inums[i]; //временная переменная, чтобы не потерять значение Inums[i]
                Inums[i] = Inums[indx];
                Inums[indx] = temp;
            }

            Console.WriteLine("\r\nОтсортированный массив:");
            
            foreach (int value in Inums)
            {
                Console.Write($"{value} ");
            }
        }
    }
    
}

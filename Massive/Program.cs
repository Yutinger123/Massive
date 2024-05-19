using System.ComponentModel.DataAnnotations;

namespace Massive;

class Program
{
    static void Main(string[] args)
    {
        //Для работы goto
        Massive:
        {
            try
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1. Одномерный массив");
                Console.WriteLine("2. Многомерный массив(2-x мерный)");
                Console.WriteLine("3. Ступенчатый массив");
                Console.WriteLine("4. Многомерный массив(3-x мерный)(????????)");
                Console.WriteLine("5. ПЗ12");
                Console.Write("Выбор: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: // Одномерный массив
                        //Ввод массива
                        Console.Write("Введи размер массива: ");
                        int p = int.Parse(Console.ReadLine());
                        Random r = new Random();
                        int[] R = new int[p];
        
                        //Значения для Random's
                        Console.Write("Минимальное число a: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Максимальное число b: ");
                        int b = int.Parse(Console.ReadLine());
                
                        //Строка
                        for (int i = 0; i < R.Length; i++) 
                        {
                            R[i] = r.Next(a, b);
                            Console.Write(R[i] + ",");
                        }
                
                        //Столбец
                        for (int j = 0; j < R.Length; j++)
                        {
                            R[j] = r.Next(a, b);
                            Console.WriteLine(R[j]);
                        }
                        goto Massive;
                        break;
            
                    case 2: //Многомерный массив(2-х значный массив)
                        //Ввод массива
                        Console.Write("Введи размер 1 массива(Строки): ");
                        int po = int.Parse(Console.ReadLine());
                        Console.Write("Введи размер 2 массива(Столбцы): ");
                        int poi = int.Parse(Console.ReadLine());
                        Random ro = new Random();
                        int[,] ri = new int[po, poi];
                        
                        int rows = ri.GetUpperBound(0) + 1;     // количество строк
                        int columns = ri.Length / rows;        // количество столбцов
                
                        //Значения для Random's
                        Console.Write("Минимальное число a: ");
                        int ai = int.Parse(Console.ReadLine());
                        Console.Write("Максимальное число b: ");
                        int bi = int.Parse(Console.ReadLine());
        
                        for (int i = 0; i < rows; i++)
                        {
                            int max = ri[0, i];
                            int maxRow = 0;
                            
                            for (int j = 0; j < columns; j++)
                            {
                                ri[i, j] = ro.Next(ai, bi);
                                Console.Write(ri[i, j] + " ");
                                if (ri[i, j] > max)
                                {
                                    max = ri[i, j];
                                    maxRow = j + 1;
                                }
                            }
                            Console.WriteLine("max: " + max + ", rows: " + maxRow);
                            //Console.WriteLine("rows:{0}", maxRow);
                        }
                        goto Massive;
                        break;
                    case 3: //Ступенчатый массив
                            //Ввод массива
                            Console.Write("Введи размер массива: ");
                            int yu = int.Parse(Console.ReadLine());
                            Random ry = new Random();
                            int[][] ty = new int[yu][];
                            
                            //Значения для Random's
                            //Console.Write("Минимальное число a: ");
                            //int aib = int.Parse(Console.ReadLine());
                            //Console.Write("Максимальное число b: ");
                            //int bia = int.Parse(Console.ReadLine());
                            Console.WriteLine("Создание элементов строк");
                            for (int i = 0; i < ty.Length; i++)
                            {
                                int a1 = ry.Next(1, 5);
                                Console.Write($"Ty[{i}] = new int[{a1}]" + " ");
                                for (int j = 0; j < a1; j++)
                                {
                                    int a2 = ry.Next(1, 10);
                                    Console.Write("{" + a2 + "}" + " ");
                                }
                                Console.WriteLine();
                            }
                            goto Massive;
                            break;
                    case 4:
                            break;
                    case 5:
                        //Ввод массива
                        Console.Write("Введи размер 1 массива(Строки): ");
                        int one = int.Parse(Console.ReadLine());
                        Console.Write("Введи размер 2 массива(Столбцы): ");
                        int two = int.Parse(Console.ReadLine());
                        
                        int[,] ry1 = new int[one, two];
                        
                        for (int i = 0; i < ry1.GetLength(0); i++)
                        {
                            for (int j = 0; j < ry1.GetLength(1); j++)
                            {
                                if ((i == 0) || (j == 0) || (i == one - 1) || (j == two - 1))
                                {
                                    ry1[i, j] = 1;
                                }
                                Console.Write(ry1[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        goto Massive;
                        break;
                    default: 
                        Console.WriteLine("Выбор неверен");
                        goto Massive;
                        break;
                } 
            }
            //При ошибке любого вида, возращает программу в исходное состояние
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n<<- Возращаемся в начало");
                goto Massive;
                throw;
            }
        }
        Console.ReadKey();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp1HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example15();
            
        }

        /// <summary>
        /// 1.Напечатать весь массив целых чисел
        /// </summary>
        static void Example1() {
            int[] A = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }


        /// <summary>
        /// 3. Найти индекс максимального четного значения в массиве
        /// </summary>
        static void Example2()
        {
            int[] A = new int[10];
            Console.WriteLine("Введите 10 целых чисел");

            for(int i = 0; i < A.Length; i++)
            {
                Console.Write("");
                if (int.TryParse(Console.ReadLine(), out A[i]))
                {
                    // Ввод успешен
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    i--; // Повторить ввод для текущего индекса
                }
            }


            int maxNum = int.MinValue; 
            int maxNumIndex = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0 && A[i] > maxNum)
                {
                    maxNum = A[i];
                    maxNumIndex = i;
                }
            }

            if (maxNumIndex != -1)
            {
                Console.WriteLine("Индекс максимального четного значения: " + maxNumIndex);
            }
            else
            {
                Console.WriteLine("В массиве нет четных значений.");
            }


        }

        /// <summary>
        /// 4. Удалить элемент из массива по индексу.
        /// </summary>
        static void Example3()
        {
            int[] A = new int[10];
            Console.WriteLine("Введите 10 целых чисел:");

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("");
                if (int.TryParse(Console.ReadLine(), out A[i]))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    i--; 
                }
            }

            int index;
            Console.WriteLine("Введите индекс элемента: ");
            int.TryParse(Console.ReadLine(), out index);

            if (index >= 0 && index <= 10)
            {
                int[] B = new int[10 - 1];

                for (int i = 0; i < index; i++)
                {
                    B[i] = A[i];
                }
                for (int i = index; i < B.Length; i++)
                {
                    B[i] = A[i + 1];
                }
                Console.WriteLine("Новый массив:");
                foreach (int number in B)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Некорректный индекс ");
            }
        }


        /// <summary>
        /// 6. Вставить элемент в массив по индексу
        /// </summary>
        static void Example4()
        {
            int[] A = new int[10];

            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("");
                if (int.TryParse(Console.ReadLine(), out A[i]))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод ");
                    i--;
                }
            }

            
            int index;
            Console.WriteLine("Введите индекс элемента: ");
            if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < A.Length)
            {
                Console.WriteLine("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out int numberToInsert))
                {
                    for (int i = A.Length - 1; i > index; i--)
                    {
                        A[i] = A[i - 1];
                    }
                    A[index] = numberToInsert;

                    Console.WriteLine("Обновленный массив:");
                    foreach (int element in A)
                    {
                        Console.Write(element + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод ");
                }
            }
            else
            {
                Console.WriteLine("Некорректный индекс ");
            }



        }

        /// <summary>
        /// 7. Удалить из строки слова, в которых есть буква 'a'
        /// </summary>
        static void Example5()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            // Разбиваем строку на слова, разделенные пробелами
            string[] words = input.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                bool containsA = false;

                foreach (char letter in word)
                {
                    if (letter == 'a' || letter == 'A')
                    {
                        containsA = true;
                        break; 
                    }
                }

                // Если в слове нет 'a', добавляем его к результату
                if (!containsA)
                {
                    result += word + " ";
                }
            }

            // Удаляем лишний пробел в конце строки и выводим результат
            result = result.Trim();
            Console.WriteLine("Результат: " + result);

        }


        /// <summary>
        /// 14. Написать программу, которая считывает символы с клавиатуры, 
        /// пока не будет введена точка. Программа должна сосчитать количество 
        /// введенных пользователем пробелов. (Подсказка. IF, Length)
        /// </summary>
        static void Example6()
        {
            Console.WriteLine("Введите текст ");
            string text = Console.ReadLine();

            int spaceCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    spaceCount++;
                }
            }

            Console.WriteLine("Количество пробелов " + spaceCount);

        }


        /// <summary>
        /// 17. Дано целое число N (> 0), найти число, полученное при прочтении числа 
        /// N справа налево. Например, если было введено число 345, 
        /// то программа должна вывести число 543.
        /// </summary>
        static void Example7()
        {
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());

            string numString = n.ToString();
            string newNumString = "";

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                newNumString += numString[i];
            }

            int newN = int.Parse(newNumString);
            Console.WriteLine("Новое число: " + newN);
        }


        /// <summary>
        /// 22. Написать программу, подсчитывающую количество цифр в заданной строке.
        /// </summary>
        static void Example8()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            int digitCount = 0;

            foreach (char symb in text)
            {
                if (char.IsDigit(symb))
                {
                    digitCount++; 
                }
            }

            Console.WriteLine("Количество цифр в строке: " + digitCount);

        }


        /// <summary>
        /// 23. Дан текст. Определить, есть ли в тексте слово one.
        /// </summary>
        static void Example9()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            if (text.Contains("one"))
            {
                Console.WriteLine("Текст содержит слово 'one'.");
            }
            else
            {
                Console.WriteLine("Текст не содержит слово 'one'.");
            }

        }


        /// <summary>
        /// 5. Удаление элементов из массива по значению
        /// </summary>
        static void Example10()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int valueToRemove = 5;

            int indexToRemove = -1; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToRemove)
                {
                    indexToRemove = i; 
                    break; 
                }
            }

            if (indexToRemove != -1)
            {
                int[] newNumbers = new int[array.Length - 1];
                for (int i = 0; i < indexToRemove; i++)
                {
                    newNumbers[i] = array[i];
                }
                for (int i = indexToRemove; i < array.Length - 1; i++)
                {
                    newNumbers[i] = array[i + 1];
                }

                array = newNumbers;
            }
            Console.WriteLine("Обновленный список чисел:");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

        }

        /// <summary>
        /// 8.Удалить из строки слова, в которых есть буква 'a'
        /// 
        /// Данный код работает только для предложений на английском языке
        /// </summary>
        static void Example11()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string newString = "";

            foreach (string word in words)
            {
                if (!word.Contains('a'))
                {
                    newString += word + " ";
                }
            }

            // Выводим результат
            Console.WriteLine("Результат: " + newString);
        }


        /// <summary>
        /// 10. В строке все слова, которые начинаются и заканчиваются одной 
        /// буквой, выделить квадратными скобками
        /// </summary>

        static void Example12()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string pattern = @"\b(\w)\w*\1\b";
            string newString = Regex.Replace(text, pattern, "[$0]");
            Console.WriteLine("Результат:");
            Console.WriteLine(newString);

        }

        /// <summary>
        /// 11. Обнулить элементы тех строк, на пересечении которых 
        /// с главной диагональю стоит четный элемент
        /// </summary>
        static void Example13()
        {
            int n = 3;
            int[,] matrix = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }


            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Обнуляем элементы строк, на пересечении с главной диагональю, если там стоит четный элемент
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // Выводим обновленную матрицу
            Console.WriteLine("\nОбновленная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// 12. Обнулить элементы тех столбцов, на пересечении которых 
        /// с главной диагональю стоит четный элемент
        /// </summary>
        static void Example14()
        {
            int n = 3; 
            int[,] matrix = new int[n, n];

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 10); 
                }
            }

            // Выводим исходную матрицу
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Обнуляем элементы столбцов, на пересечении с главной диагональю, если там стоит четный элемент
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = 0;
                    }
                }
            }

            // Выводим обновленную матрицу
            Console.WriteLine("\nОбновленная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// 13. Дана строка, посчитать количество вхождений буквы P
        /// </summary>
        static void Example15()
        {
            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();

            // Преобразуем строку в верхний регистр
            inputString = inputString.ToUpper();

            char targetChar = 'P'; 
            int count = 0; 

            foreach (char c in inputString)
            {
                if (c == targetChar)
                {
                    count++;
                }
            }

            // Выводим количество вхождений
            Console.WriteLine("Буква " +targetChar +  " встречается " + count + " раз");
        }
    }
}

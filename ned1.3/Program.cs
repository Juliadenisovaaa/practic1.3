using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ned1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // счетчик отрицательных чисел
            string input; // введенная строка пользователем
            int number; // преобразованный в число ввод пользователя
            bool isValidInput; // проверка на допустимое значения

            Console.WriteLine("Введите числа (0 для завершения):");q

            do
            {
                do
                {
                    Console.Write("Введите число: ");
                    input = Console.ReadLine();

                    isValidInput = int.TryParse(input, out number);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    }
                } while (!isValidInput);

                if (number < 0) // если отрицательное число то увеличиваем
                {
                    count++;
                }

            } while (number != 0);

            Console.WriteLine("Количество отрицательных чисел: " + count);
            Console.ReadKey();

        }
    }
}

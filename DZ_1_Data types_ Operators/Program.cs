/*
 Задача  3
Пользователь вводит с клавиатуры четыре цифры. 
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
сформировать число 1578

Задача  3.1
Пользователь вводит с клавиатуры  цифры до тех пор пока не будет пустая строка.
Необходимо создать число, содержащее эти цифры.
 
Задача  4
Пользователь вводит шестизначное число. 
После чего пользователь вводит номера разрядов для обмена цифр. 
Например, если пользователь ввёл один и шесть — это 
значит, что надо обменять местами первую и шестую цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре буется вывести сообщение об ошибке.

Задача 5
Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.

*/


using System;

class Program
{
    int num1 = 0, num2 = 0, num3 = 0, num4 = 0;

    //Task 4 
    static void SwapElement(int[] array, int index1, int index2)
    {
        if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
        {
            Console.WriteLine("Ошибка: введены неверные номера разрядов!");
        }
        int temp = array[index1 - 1];
        array[index1 - 1] = array[index2 - 1];
        array[index2 - 1] = temp;
    }
    public int Task4()
    {
        Console.WriteLine("Task 4.\n Enter a six-digit number-> ");
        num1 = int.Parse(Console.ReadLine());

        // Проверяем количество цифр в числе
        if (num1 < 100000 || num1 > 999999)
        {
            Console.WriteLine("Mistake! The number is the six digits!!");
        }
        Console.WriteLine("Enter digit numbers for digit exchange-> ");

        // Считываем номера разрядов для обмена
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());

        // Преобразуем число в массив цифр
        int[] arr = new int[6];
        for (int i = 5; i >= 0; i--)
        {
            arr[i] = num1 % 10;
            num1 /= 10;
        }
        // Проверяем на валидность разрядов и меняем цифры
        SwapElement(arr, num2, num3);

        // Собираем число из цифр
        int num4 = 0;
        for (int i = 0; i < 6; i++)
        {
            num4 = num4 * 10 + arr[i];
        }
        return num4;
    }

    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0, num3 = 0, num4 = 0, number = 0;

        //Task 3
        Console.WriteLine("Task 3\nEnter the four numbers-> ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        num4 = int.Parse(Console.ReadLine());

        static int Task3(ref int variable1, ref int variable2, ref int variable3, ref int variable4)
        {
            int value = variable1 * 1000 + variable2 * 100 + variable3 * 10 + variable4;
            return value;
        }
        Console.WriteLine($"Result: {Task3(ref num1, ref num2, ref num3, ref num4)}\n");
             

        // Задача  3.1
        Console.WriteLine("Task 3\nEnter the numbers-> ");
        string input;
        do 
        {
            input = Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            {
                if(int.TryParse(input, out int digit))
                {
                    number = number * 10 + digit;
                }
                Console.WriteLine("The number is not entered correctly!! \nTry again -> ");
            }
        } while (!string.IsNullOrEmpty(input));
        Console.WriteLine($"Rezalt number: {number}\n");

        //Task 4
        Program p = new Program();
        Console.WriteLine("Result: " + p.Task4() + '\n');

        // Task 5
        Console.WriteLine("Enter the date in the format (20.05.2023) -> ");
        input = Console.ReadLine();

    }
}



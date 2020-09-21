using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace LabRab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1a
            
            Console.WriteLine("Введите значение логической переменной bool");
            bool first = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение логической переменной bool, равное {first}");
            
            Console.WriteLine("Введите значение переменной byte (от 0 до 255)");
            byte second = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение byte, равное {second}");
            
            Console.WriteLine("Введите значение переменной sbyte (от -128 до 127");
            sbyte third = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение sbyte, равное {third}");
            
            Console.WriteLine("Введите значение переменной char (1 символ)");
            char fourth = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение char, равное {fourth}");
            
            Console.WriteLine("Введите значение переменной decimal (от -1*10^-28 до 1*10:28)");
            decimal fifth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение decimal, равное {fifth}");
            
            Console.WriteLine("Введите значение переменной double (от -5*10:-324 до 1.7*10:308)");
            double sixth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"вы ввели значение переменной double, равное {sixth}");
            
            Console.WriteLine("Введите значение переменной float (от -3.4*10^38 до 3.4*10^38");
            float seventh = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение переменной float, равное {seventh}");
            
            Console.WriteLine("Введите значение переменной int (от -2147483648 до 2147483647)");
            int eighth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение int, равное {eighth}");
            
            Console.WriteLine("Введите значение переменной uint (от 0 до 4294967295)");
            uint nineth = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение uint, равное {nineth}");
            
            Console.WriteLine("Введите значение переменной long(от –9223372036854775808–9223372036854775808 до 9223372036854775807)");
            long tenth = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение переменной long, равное {tenth}");
            
            Console.WriteLine("Введите значение переменной ulong (от 0 до 18446744073709551615)");
            ulong eleventh = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение переменной ulong, равное {eleventh}");
            
            Console.WriteLine("Введите значение переменной short (от -32768 до 32767)");
            short twelvth = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение переменной short, равное {twelvth}");
            
            Console.WriteLine("Введите значение переменной ushort (от 0 до 65535)");
            ushort thertenth = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"Вы ввели значение переменный ushort, равное {thertenth}");

            //task 1b

            sbyte Change1 = (sbyte)eighth; //int to sbyte
            byte Change2 = (byte)twelvth; //ushort to byte
            short Change3 = (short)nineth; //uint to short
            ushort Change4 = (ushort)eleventh; //ulong to ushort
            uint Change5 = (uint)third; //sbyte to uint

            Console.WriteLine($"Значение которые прошли явное преобразование типов {Change1}, {Change2}, {Change3}, {Change4}, {Change5}");

            long Change1A = eighth; //int to long
            int Change2A = twelvth; //ushort to int
            double Change3A = nineth; //uint to double
            float Change4A = eleventh; //ushort to float
            decimal Change5A = third; //sbyte to decimal

            Console.WriteLine($"Значения, которые прошли неявное преобразование типов {Change1A}, {Change2A}, {Change3A}, {Change4A}, {Change5A}");
            //task 1d
            Console.WriteLine($"{Change5A.GetType()} - тип данных который прошел неявное преобразование"); //Демонстрация работы неявно преобразованной переменной

            //task 1c
            object pac = 5; //запаковка
            int unpac = (int)pac; //распаковка

            Console.WriteLine($"{pac.GetType()} - тип запакованной переменной, {unpac.GetType()} - тип распакованной переменной");

            //task 1e
            int? a = null;
            Console.WriteLine($"{a.Value} - значение nullable перемененной а");

            //task 1f
            //var taskf = -1;
            //uint taskf2 = (uint)taskf; //ошибка вызвана невозможностью присвоения данного числа данному типу

            //task 2a 
            string message1 = "hello";
            string message2 = "world";
            int result = string.Compare(message1, message2);

            if (result < 0) {
                Console.WriteLine("строки равны"); 
            } else Console.WriteLine("строки не равны");

            //task 2b
            string task2b1 = "hello ";
            string task2b2 = "world! ";
            string task2b3 = string.Concat(task2b1, task2b2); //объединение
            Console.WriteLine($"{task2b3}");

            string task2b4 = task2b3; //копирование
            Console.WriteLine($"{task2b4} - копированная строка");

            Console.WriteLine(task2b3.Substring(2)); //вывод подстроки



            string[] task2b5 = task2b3.Split(" "); //разбитие на слова
            Console.WriteLine(task2b5);

            //пример интерполяции выше

            string task2c1 = "asd";
            string task2c2 = "";
            string task2c3 = null;           //метод is full or empty
            Console.WriteLine("is null or empty");
            Console.WriteLine(string.IsNullOrEmpty(task2c1));
            Console.WriteLine(string.IsNullOrEmpty(task2c2));
            Console.WriteLine(string.IsNullOrEmpty(task2c3));

            StringBuilder task2d = new StringBuilder("Hello again!");
            Console.WriteLine($"Длина строки: {task2d.Length}");
            Console.WriteLine($"Емкость строки {task2d.Capacity}");
            Console.WriteLine(task2c3.Insert(0, "say ")); //вставка
            Console.WriteLine(task2c3.Replace("agin! ", "world")); //замена слова
            Console.WriteLine(task2c3.Remove(0, 3)); //удаление с начала

            //task3a
            int[,] mass = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = mass.GetUpperBound(0) + 1;
            int columns = mass.Length / rows;

            //task3b 
            int[] mass2 = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine(mass2);
            Console.WriteLine($"{mass2.Length} - длина массива");
            for (int i = 0; i < mass2.Length - 1; i += 2)
            {
                int temp = mass2[i];
                mass2[i] = mass2[i + 1];
                mass2[i + 1] = temp;
            }
            Console.WriteLine(mass2);
            //task 3c
            int[][] mass3c = new int[3][];
            mass3c[0] = new int[2] { 1, 2 };          
            mass3c[1] = new int[3] { 1, 2, 3 };       
            mass3c[2] = new int[5] { 1, 2, 3, 4, 5 };
            //task3d
            var mass3d = new int[]{ 1, 2, 3, 4, 5 };
            //task4a
            
        }
    }
}

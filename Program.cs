// Почувствуй себя джуном *
// 5. Дано число. Проверить кратно ли оно 7 и 23.
// int number = 483;
// if ((number % 7 == 0) && (number % 23 == 0)) 
// {
//     Console.WriteLine(number + " делится на 7 и 23");
// }
// else 
// {
//     Console.WriteLine(number + " не делится на 7 и 23");
// }
// 
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
// int day = 3;
// if (day >7)
// {
//     Console.WriteLine("Приходие завтра");
// }
// else if (day < 6)
// {
//     Console.WriteLine("Будний день");
// }
// else Console.WriteLine("Выходной");
// 
// 17. По двум заданным числам проверять является ли одно квадратом другого числа.
// int a = 9;
// int b = 81;
// if (a*a == b) 
// {
//     Console.WriteLine(a +"^2 = " + b);
// }
// else if (b*b == a) 
// {
//     Console.WriteLine(b + "^2 = " + a);
// }
// else 
// {
//     Console.WriteLine("Число не является квадратом другого");
// }
// 
// 18. Проверить истинность утверждения ¬ (X ⋁ Y) = ¬X ⋀ ¬Y.
// bool[] x = {true, false, true, false};
// bool[] y = {true, true, false, false}; 
// string ansver = "Истинно!";
// for (int i = 0; i < 4; i++)
// {
//     bool d = !(x[i] | y[i]);
//     bool f = !x[i] & !y[i];
//     if (d == f) {}
//     else {
//         ansver = "Ложь!";
//     }
// }
// Console.WriteLine(ansver);
// 
// 19. Определить номер четверти плоскости, в которой находится точка 
// с координатами Х и У, причем X ≠ 0 и Y ≠ 0.
// int x = 5;
// int y = -10;
// if (x > 0 & y > 0) {
//   Console.WriteLine("I четверть");
//    }
// if (x < 0 & y > 0) {
//    Console.WriteLine("II четверть");
//    }
// if (x < 0 & y < 0) {
//    Console.WriteLine("III четверть");
//    }
// if (x > 0 & y < 0) {
//    Console.WriteLine("IV четверть");
//    }
// 
// 20. Задать номер четверти, показать диапазоны для координат.
// int quarNum = 3;
// if (quarNum == 1) 
// {
//     Console.WriteLine("X > 0 ; Y > 0");
//     }
// else if (quarNum == 2) 
// {
//     Console.WriteLine("X < 0 ; Y > 0");
// }
// else if (quarNum == 3) 
// {
//     Console.WriteLine("X < 0 ; Y < 0");
// }
// else if (quarNum == 4) 
// {
//     Console.WriteLine("X > 0 ; Y < 0");
// }
// else 
// {
//     Console.WriteLine("Приходите завтра");
// }
//
// 21. Программа проверяет пятизначное число на палиндром.
// int num = 23932;
// string chislo = num.ToString();
// string ansver = "Палиндром";
// for (int i = 0; i < chislo.Length; i++) 
// {
//     if (chislo[i] < chislo[chislo.Length-1-i] || chislo[i] > chislo[chislo.Length-1-i])
//     {
//         ansver = "Не является палиндромом";
//     }
// } 
// Console.WriteLine(ansver);
// // 
// 22. Найти расстояние между точками в пространстве 2D / 3D.
//
// double a1 = 5, a2 = 10; // A(a1;a2)
// double b1 = -3, b2 = -8; // B(b1;b2)
// double d1 = a1 - b1;
// double d2 = a2 - b2;
// double s = Math.Sqrt(d1*d1 + d2*d2);
// Console.WriteLine("Расстояние АВ равно  " + s);
//
// То же в 3D.
//
// double a1 = 5, a2 = 10, a3 = 3; // A(a1;a2;a3)
// double b1 = -3, b2 = -8, b3 = -5; // B(b1;b2;b3)
// double d1 = a1 - b1; 
// double d2 = a2 - b2;
// double d3 = a3 - b3;
// double s = Math.Sqrt(d1*d1 + d2*d2 + d3*d3);
// Console.WriteLine("Расстояние АВ равно  " + s);
//
// Почувствуй себя мидлом.
// 23. Показать таблицу квадратов чисел от 1 до N.
//
// int n = 10;
// for(int i = 1; i < = n; i++){
//     Console.WriteLine(i + "^2 = " + i*i);
// }
//
// 24. Найти кубы чисел от 1 до N.
//
//  int n = 10;
// for(int i = 1; i < = n; i++){
//     Console.WriteLine(i + "^3 = " + Math.Pow(i,3));
// }
//
// 25. Найти сумму чисел от 1 до А.
//
// int A = 123, s = 0;
// for (int i = 1; i <= A; i++)
// {
//    s+=i; 
// }
// Console.WriteLine("Сумма равна " + s);
//
// 26. Возьмите число А в натуральную степень B используя цикл.
//
// int a = 2, b = 7;
// int s = 1;
// for(int i = 0; i < b; i++){
// s = s * a;
// }
// Console.WriteLine(s);
//
// 27. Определить количество цифр в числе.
//
// int number = 456987;
// int count = 0;
// while(number > 0)
// {
//     number = number / 10;
//     count++;
// }
// Console.WriteLine("Количество цифр в числе  " + count);
//
// 28. Подсчитать сумму цифр в том числе.
//
// int number = 456987;
// int count = 0;
// while(number > 0)
// {
//     count = count + number % 10;
//     number = number / 10;
// }
// Console.WriteLine("Сумма цифр в числе  " + count);
//
// 29. Написать программу вычислений произведения чисел от 1 до N.
//
// int N = 15;
// int mult = 1;
// for (int i = 2; i <= N; i++)
// {
//     mult = mult * i;
// }
// Console.WriteLine(mult);
//
// 30. Показать кубы чисел, заканчивающихся на четную цифру.
//
// int max = 15; // Максимальное число
// for (int i = 2; i <= max; i++)
// {
//     double cube = Math.Pow(i,3);
//     if (cube % 2 == 0)
//     {
//         Console.WriteLine(cube);
//     }
// }
//
// Почувствуй себя синьором.
// 31. Задать массив из 8 элементов и вывести их на экран.
// int[] array = {12,36,98,74,12,36,98,74};
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
//
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// int[] array = new int[8];
// Random rand = new Random();
// for (int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(0,2);
//     Console.Write(array[i] + " ");
// }
//
// 33. Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных / отрицательных элементов массива.
//
// int[] array = new int[12];
// Random rand = new Random();
// int sumPositive = 0;
// int sumNegative = 0;
// for (int i = 0; i < 12; i++)
// {
//     array[i] = rand.Next(-9,10);
//     Console.Write(array[i] + " ");
//     if(array[i] > 0)
//     {
//         sumPositive = sumPositive + array[i];
//     }
//     else{
//         sumNegative = sumNegative + array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Сумма положительных элементов  " + sumPositive);
// Console.WriteLine("Сумма отрицательных элементов  " + sumNegative);
//
// 34.Написать программу, заменяющую элементоы на противоположные.
//
// int[] array = {1,-4,7,-8,9,-5,6};
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i]*(-1);
//     Console.Write(array[i] + " ");
// }
//
// 35. Определить, присутствует ли в заданном массиве, некоторое число.
//
// int[] array = {1,7,9,5,3,0,5};
// int reqNum = 5;
// int k = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] == reqNum)
//     {
//        Console.WriteLine( "Число присутствует на  " + (i+1) + "-ой позиции");
//        k++;
//     }
// }
// if(k == 0){
//     Console.WriteLine($"Число  {reqNum}  отсутствует");
// }
//
// 36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных \ четных чисел.
//
// int[] array = new int[20];
// int evenNum = 0;
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(100,1000);
//     Console.Write(array[i] + " ");
//     if(array[i] % 2 == 0){
//         evenNum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество четных " + evenNum);
// Console.WriteLine("Количество нечетных " + (array.Length - evenNum));
//
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].
//
// int[] array = new int[123];
// Random rand = new Random();
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0,1000);
//     Console.Write(array[i] + " ");
//     if(array[i] > 9 && array[i] < 100)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество элементов " + count);
//
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции.
//
// int[] array = {1,4,7,8,9,6,3,2,5,0,};
// int s = 0;
// for (int i = 0; i < array.Length/2; i++)
// {
//     s+=array[2*i];
// }
//     Console.WriteLine("Сумма чисел равна " + s);
//
// 39. Найти число пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д.
//
//  int[] array = {1,4,7,8,9,6,3,2,5,0,5};
//  Console.WriteLine("Ответ: " + array.Length/2);
//  // Вывод пар:
// for (int i = 0; i < array.Length/2; i++)
// {
//     Console.WriteLine("("+ array[i] + " , " + array[array.Length -i-1] + ')');
// }
//
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным
// и минимальным элементом.
//
// Random ran = new Random();
// double[] array = new double[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = ran.NextDouble() * 100;// Числа из промежутка [0 ; 100)
//     Console.WriteLine(array[i] + " ");
// }
// double max = array[0];// Максимальный элемент массива
// double min = array[0];// Минимальный элемент массива
// for (int i = 1; i < array.Length; i++)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }
//     if(array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.WriteLine("Минимальный элемент " + min);
// Console.WriteLine("Максимальный элемент " + max);
// Console.WriteLine($"Их разность {max - min}");
//
// Почувствуй себя лидом.
// 41. Выяснить являются ли три числа длинами сторон треугольника.
//
// int a = 4;
// int b = 5;
// int c = 6;
// if(a > 0 && b > 0 && c > 0 && a < b+c && b < a+c && c < a+b)
// {
//     Console.WriteLine(a +" " + b + " " + c + " являются сторонами треугольника");
// }
// else
// {
//     Console.WriteLine(a +" " + b + " " + c + " не являются сторонами треугольника");
// }
//
// 42. Определить сколько чисел больше 0 введено с клавиатуры.
//
// Console.WriteLine("Введите число");
// Console.WriteLine("Для завершения введите END");
// int number = 0;
// int count = 0;
// string? input ="";
// do
// {
//     input = Console.ReadLine()!;
//     if(input.ToLower() != "end"){
//         number = Convert.ToInt32(input);
//     }
//     if(number > 0)
//     {
//         count++;
//     }
//     number = 0;
//     Console.WriteLine($"Положительных чисел: {count}");
//     }
//     while(input.ToLower() != "end");
// Без защиты от "дурака".
//
// 43. Написать программу преобразования десятичного числа в двоичное.
//
// int num = 15;
// string bin = "";
// while(num > 0)
// {
//     if(num % 2 == 1){
//         bin = "1" + bin;
//     }
//     else{
//         bin = "0" + bin;
//     }
//     num = num / 2;
// }
// Console.WriteLine(bin);
//
// 44. Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.
//
// double b1 = 5;
// double k1 = 2;
// double b2 = 3;
// double k2 = 1;
// if(k1 != k2)
// {
//     Console.WriteLine($"Прямые пересекаются в точке ({(b2 - b1) / (k1 - k2)} ; {(k1 * b2 - k2 * b1) / (k1  -k2)})");
// }
// else if(b1 == b2){
//     Console.WriteLine("Прямые совпадают");
// }
// else
// {
//     Console.WriteLine("Прямые не пересекаются.");
// }
//
// 45. Показать числа Фибоначчи.
//
// int n = 20; // Количество чисел, которые требуется показать.
// int[] fib = new int[n];
// fib[0] = 1; fib[1] = 1;
// Console.Write("1 1 ");
// for (int i = 2; i < n-1; i++)
// {    
//     fib[i] = fib[i-1] + fib[i-2];   
//     Console.Write(fib[i] + " ");
// }
//
// 46. Написать программу масштабирования фигуры.
//
// Console.Clear();
// Console.WriteLine("Введите координаты вершин фигуры (X1 ; Y1) (X2 ; Y2) (X3 ; Y3) (X4 ; Y4)");
// Console.Write("(");
// double[] coordinate = new double[8];
// int left = 1; // Отступ слева
// for (int i = 0; i < 8; i++)
// {
//     string x = Console.ReadLine()!;// Получает строку с клавиатуры
//     coordinate[i] = Convert.ToDouble(x);
//     left = left + x.Length;
//     Console.SetCursorPosition(left, Console.CursorTop - 1);
//     if(i % 2 == 0)
//     {
//         Console.Write(" ; ");
//     }
//     else if(i != 7)
//     {
//         Console.Write(") (");
//     }
//     left+=3;
// }
// Console.WriteLine(")");
// Console.WriteLine("Введите коэффициент масштабирования");
// double k = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"({coordinate[0] * k} ; {coordinate[1] * k}) ({coordinate[2] * k} ; {coordinate[3] * k}) ({coordinate[4] * k} ; {coordinate[5] * k}) ({coordinate[6] * k} ; {coordinate[7] * k})");
//
// 47. Написать программу копирования массива.
//
// Random n = new Random();
// int[] array = new int[n.Next(2,20)];
// int[] copy = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = n.Next(0,100);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// Console.Write("Кoпия массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     copy[i] = array[i];
//     Console.Write(copy[i] + " ");
// }
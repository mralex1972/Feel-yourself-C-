// Почувствуй себя джуном *
// 15. Дано число. Проверить кратно ли оно 7 и 23.
// int number = 483;
// if ((number % 7 == 0) && (number % 23 == 0)) 
// Console.WriteLine(number + " делится на 7 и 23");
// else Console.WriteLine(number + " не делится на 7 и 23");
// 
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
// int day = 3;
// if (day >7)
// Console.WriteLine("Приходие завтра");
// else if (day < 6)
// Console.WriteLine("Будний день");
// else Console.WriteLine("Выходной");
// 
// 17. По двум заданным числам проверять является ли одно квадратом другого числа.
// int a = 9;
// int b = 81;
// if (a*a == b)
// Console.WriteLine(a +"^2 = " + b);
// else if (b*b == a)
// Console.WriteLine(b + "^2 = " + a);
// else Console.WriteLine("Число не является квадратом другого");
// 
// 18. Проверить истинность утверждения ¬ (X ⋁ Y) = ¬X ⋀ ¬Y.
// bool[] x = {true, false, true, false};
// bool[] y = {true, true, false, false};
// int z = 0; 
// string ansver = "Истинно!";
// for (int i = 0; i < 4; i++)
// {
//     bool d = !(x[i] | y[i]);
//     bool f = !x[i] & !y[i];
//     if (d == f) 
//     z++;
//     else ansver = "Ложь!";
// }
// Console.WriteLine(ansver);
// 
// 19. Определить номер четверти плоскости, в которой находится точка 
// с координатами Х и У, причем X ≠ 0 и Y ≠ 0.
// int x = 5;
// int y = -10;
// if (x > 0 & y > 0) Console.WriteLine("I четверть");
// if (x < 0 & y > 0) Console.WriteLine("II четверть");
// if (x < 0 & y < 0) Console.WriteLine("III четверть");
// if (x > 0 & y < 0) Console.WriteLine("IV четверть");
// 
// 20. Задать номер четверти, показать диапазоны для координат.
// int quarNum = 8;
// if (quarNum == 1) 
// Console.WriteLine("X > 0 ; Y > 0");
// else 
// if (quarNum == 2) 
// Console.WriteLine("X < 0 ; Y > 0");
// else 
// if (quarNum == 3) 
// Console.WriteLine("X < 0 ; Y < 0");
// else 
// if (quarNum == 4) 
// Console.WriteLine("X > 0 ; Y < 0");
// else 
// Console.WriteLine("Приходите завтра");
//
// 21. Программа проверяет пятизначное число на палиндром.
// int num = 23932;
// string chislo = num.ToString();
// string ansver = "Палиндром";
// for (int i = 0; i < chislo.Length; i++) 
// {
//     if (chislo[i] < chislo[chislo.Length-1-i] || chislo[i] > chislo[chislo.Length-1-i])
//     ansver = "Не является палиндромом";
// } 
// Console.WriteLine(ansver);
// // 
// 22. Найти расстояние между точками в пространстве 2D / 3D.
//
// double a1 = 5, a2 = 10; // A(a1;a2)
// double b1 = -3, b2 = -8; // B(b1;b2)
// double s = Math.Sqrt((a1 - b1) * (a1 - b1) + (a2 - b2) * (a2 - b2));
// Console.WriteLine("Расстояние АВ равно  " + s);
//
// То же в 3D.
//
// double a1 = 5, a2 = 10, a3 = 3; // A(a1;a2;a3)
//  double b1 = -3, b2 = -8, b3 = -5; // B(b1;b2;b3)
//  double s = Math.Sqrt((a1 - b1) * (a1 - b1) + (a2 - b2) * (a2 - b2) + (a3 - b3) * (a3 - b3));
//  Console.WriteLine("Расстояние АВ равно  " + s);
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
// 25. Найти количество чисел от 1 до А.
//
// int A = 123;
// Console.WriteLine(A);
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
// 29. Написать программу вычислений произведений чисел от 1 до N.
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
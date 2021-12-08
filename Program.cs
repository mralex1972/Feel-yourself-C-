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
// int num = 23951;
// string chislo = num.ToString();
// string ansver = "Палиндром";
// for (int i = 0; i < chislo.Length; i++) 
// {
//     if (chislo[i] < chislo[4-i] || chislo[i] > chislo[4-i])
//     ansver = "Не является палиндромом";
// } 
// Console.WriteLine(ansver);
// 
// 22. Найти расстояние между точками в пространстве 2D / 3D.

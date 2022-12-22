// Задача 1:

// Console.WriteLine("Input three-digit number: ");
// int num = int.Parse(Console.ReadLine()!);
// if((num > 99) && (num < 1000))
// {
//     int tens = ((num % 100) - (num % 10)) / 10;
//     Console.WriteLine($"{tens}");
// }
// else
// {
//     Console.WriteLine("Input three-digit number!");
// }

// Задача 2:

// Console.WriteLine("Input a number: ");
// int num = int.Parse(Console.ReadLine()!);
// if(num < 100)
// {
//     Console.WriteLine("There is no third digit");
// }
// else if((num > 99) && (num < 1000))
// {
//     Console.WriteLine($"Third digit is {num % 10}");
// }
// else if((num > 999) && (num < 10000))
// {
//     Console.WriteLine($"Third digit is {((num % 100) - (num % 10)) / 10}");
// }
// else if((num > 9999) && (num < 100000))
// {
//     Console.WriteLine($"Third digit is {((num % 1000) - (num % 100)) / 100}");
// }
// else
// {
//     Console.WriteLine("The number is too big!");
// }

// Задача 3:

// Console.WriteLine("Input day of week number: ");
// int w_num = int.Parse(Console.ReadLine()!);

// if((w_num > 0) && (w_num < 8))
// {
//     if((w_num >= 1) && (w_num <= 5))
//     {
//         Console.WriteLine("Working day!");
//     }
//     else
//     {
//         Console.WriteLine("Weekend!");
//     }
// }
// else
// {
//     Console.WriteLine("Wrong number!");
// }
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string s_num = Console.ReadLine();
int num = Convert.ToInt32(s_num);

if(num % 2 == 1)
{
    Console.WriteLine("число нечетное");
}
else
{
  Console.WriteLine("число четное");  
}

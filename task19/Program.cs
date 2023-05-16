// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число для проверки полиндрома: ");
int a = Convert.ToInt32(Console.ReadLine());
int temp = 0, result = 0;

if(a < 100000 || a > 10000){
result = a % 100;
while(a > 100){
    a/=10;
}
temp = a/10;
a %= 10;
temp = a * 10 + temp;
if(temp == result){
    Console.WriteLine("Число является полиндром");
}
else Console.WriteLine("Число не является полиндром");
}
else Console.WriteLine("Введите пятизначное число!");
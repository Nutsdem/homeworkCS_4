// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int getDeg(int a)
{
    int sum = 0;
string str = a.ToString();
int[] array = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     array[i] = int.Parse(str[i].ToString());
    sum = sum + array[i];
}
return sum;
}

Console.WriteLine("Введите число = ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(getDeg(num));



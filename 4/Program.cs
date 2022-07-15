Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число С: ");
int C = Convert.ToInt32(Console.ReadLine());

int max=A;

if (A> B && A > C)
{
max = A;
Console.WriteLine ("max=A");
}
else if (B > A && B > C)
{
max = B;
Console.WriteLine ("max=B");
}
else
{
max = C;
Console.WriteLine ("max=C");
}





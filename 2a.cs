//Zad  1
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if ((a + b) % 2 == 0) Console.WriteLine("TAK");
else Console.WriteLine("NIE");*/

//Zad 2
/*double a = int.Parse(Console.ReadLine());
double g = int.Parse(Console.ReadLine());
double w = a * g;
double sa = (a+g) / 2;
double sg = Math.Sqrt(w);
Console.WriteLine(sa);
Console.WriteLine(sg);*/

//Zad 3
/*int k = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
if (k==l) Console.WriteLine("TAK k" + k + " = l" + l);
else if (k==m) Console.WriteLine("TAK k" + k + " = m" + m);
else if (l == m) Console.WriteLine("TAK l" + l + " = m" + m);
else Console.WriteLine("NIE");*/

//Zad 4
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
if (a < b && a < c && a < d) Console.WriteLine(a);
else if (b < a && b < c && b < d) Console.WriteLine(b);
else if (c < a && c < b && c < d) Console.WriteLine(c);
else if (d < a && d < b && d < c) Console.WriteLine(d);
else Console.WriteLine("Są równe");*/

//Zad 5
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b) Console.WriteLine("TAK");
else Console.WriteLine("NIE");*/

//Zad 6
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
{
    if (a * a + b * b < c * c) Console.WriteLine("Rozwartokątny");
    else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) Console.WriteLine("Prostokątny");
    else if (a * a + b * b > c * c || a * a + c * c > b * b || b * b + c * c > a * a) Console.WriteLine("Ostrokątny");
}
else
{
    Console.WriteLine("To nie jest trójkąt");
}*/

double N = double.Parse(Console.ReadLine());
Console.WriteLine("N= "+N);
int i = 0;
int k = 0;
int cel = Convert.ToInt32(N);
double drob = Math.Round( N-cel , 10);
if (drob == 0) k=1;
Console.WriteLine("N= "+N+ " = " + cel + " + "+ drob);
while (( ( cel / ((int)Math.Pow((int)10,i))) ) > 0)   i++;

Console.WriteLine("число символов в целой части числа..= "+i);
while ( ( ( ( drob * ((int)Math.Pow((int)10,k))) )%10) !=0)  k++;
Console.WriteLine("число символов после запятой...= "+(k-1));
Console.WriteLine("число цифр в числе - " + (i+k-1));

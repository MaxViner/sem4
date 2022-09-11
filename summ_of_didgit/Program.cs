int summator (int N)
{
    int leng = 0;
    int sum = 0;
    while (( ( N / ((int)Math.Pow((int)10, leng))) ) > 0)   leng++;
    for (int i= 1;  i <= leng; i++)
    {
        sum = sum + N%10;
        N= N/10 ;
    }
    return sum;    
}
try
{
    Console.Write("N= ");
    int N = Math.Abs( int.Parse(Console.ReadLine()) );
    int rez = 0;
    rez = summator(N);
    Console.WriteLine(rez);
}
catch
{
    Console.WriteLine("oh...damn. Something wrong");
}
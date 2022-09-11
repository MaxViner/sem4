Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for(int i = 0;i<n;i++) 
{
    Console.WriteLine("Введите {0}-й элемент массива", i + 1);
    array[i] = int.Parse(Console.ReadLine());
}
for(int i = 0;i<n;i++)  Console.Write(array[i]+", ");

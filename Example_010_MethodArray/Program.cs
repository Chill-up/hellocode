int[] array = { 12, 42, 93, 47, 5, 56, 73, 5, 19 };

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
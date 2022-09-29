int [] array = {11,211,31,14,15,61,71,81,19,14};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
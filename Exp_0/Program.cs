
Console.WriteLine("Hello, World!");

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 11;
int b1 = 11;
int c1 = 39;

int a2 = 2212;
int b2 = 12;
int c2 = 123;

int a3 = 111113;
int b3 = 13;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

// Можно эти 3 функции вложить сразу в основную
int max = Max(max1, max2, max3);
Console.WriteLine(max);

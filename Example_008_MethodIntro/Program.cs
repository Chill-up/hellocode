int Maximum(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 34;
int c1 = 3;
int a2 = 3461;
int b2 = 232;
int c2 = 22;
int a3 = 89;
int b3 = 45006;
int c3 = 0;

// int max1 = Maximum(a1, b1, c1);
// int max2 = Maximum(a2, b2, c2);
// int max3 = Maximum(a3, b3, c3);
// int max = Maximum(max1, max2, max3);
int max = Maximum(Maximum(a1, b1, c1), Maximum(a2, b2, c2), Maximum(a3, b3, c3));
Console.WriteLine(max);
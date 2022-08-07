int Maximum(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// index        0   1   2  3   4    5   6   7   8
int[] array = { 1, 22, 13, 4, 45, 683, 17, 38, 39 };
int result = Maximum(
    Maximum(array[0], array[1], array[2]),
    Maximum(array[3], array[4], array[5]),
    Maximum(array[6], array[7], array[8])
);

Console.WriteLine(result);

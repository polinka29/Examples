// Нахождение макс числа из 9 с помощью массива и функций

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// идекс массива 0  1    2   3  4  5   6  7   8
int [] array = {19, 27, 38, 4, 55, 6, 79, 80, 91};
array[0] = 12;
Console.WriteLine(array[4]);
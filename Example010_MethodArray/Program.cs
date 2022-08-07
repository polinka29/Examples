// Есть одномерный массив array из n элементов нужно найти элемент равный find

int[] array = {1, 21, 13, 4, 56, 16, 7, 16, 98};

int n = array.Length; //длина массива
int find = 16; //это число которое вводит пользователь

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //это счетчик типо index+1
}   


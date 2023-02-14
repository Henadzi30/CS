// Метод для создания массива чисел
void FillArray(int[] collection) // В качестве аргумента в методе FillArray
// будет приниматься коллекция
{
    int length = collection.Length; // Получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Обращаемся к аргумкнту collection
        // на позицию index и положить туда новое целое число из диапазона 1-10 
        // index = index + 1;
        index++;
    }
}

// Метод для печати массива
void PrintArray(int[] col) // void - метод, который ничего не возвращает, соответсвенно в 
// функции не пишется return
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Метод, который будет находить максимальное число в массиве
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 - если в массиве нет такой позиции (можно -2, или еще что-нибудь)
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // позволяет выдавать первое вхождение 
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов,
// он будет заполнен нулями 

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // Ищем число 4 в массиве и передаем pos его индекс
Console.WriteLine(pos);
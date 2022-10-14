// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []


void Print(string[] array) {
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

Console.Write("Введите кол-во строк будет в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[a];
for (int i = 0; i < firstArray.Length; i++) {
    Console.Write($"Введите значение в {i + 1}й строке массива: ");
    firstArray[i] = Console.ReadLine();
}


string[] SelectionArray(string[] secondArray) {

    string[] NewArray = new string[secondArray.Length];

    int count = 0;

    for (int i = 0; i < secondArray.Length; i++)
    {
        if (secondArray[i].Length <= 3)
        {
            NewArray[count] = secondArray[i];
            count++;
        }
    }
    Array.Resize(ref NewArray, count);
    return NewArray;
}




Print(SelectionArray(firstArray));
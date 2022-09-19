//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. 

void SecArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] Arr1 = new string[10] {"123", "23", "hello", "world", "да", "нет", "array", "2022", "июнь", "456"};
string[] Arr2 = new string[Arr1.Length];SecArr(Arr1, Arr2);
PrintArray(Arr2);
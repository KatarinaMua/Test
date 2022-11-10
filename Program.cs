string[] arr1 = new string[6] {"hello", "2", "world", "computer sciense", "Russia", "Pur"};
string[] arr2 = new string[arr1.Length];
int a = 0;
CreateArr(arr1, arr2);
PrintArr(arr2);
void CreateArr(string[] arr1, string[] arr2)
{
    int a = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[a] = arr1[i];
        a++;
        }
    }
}
void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

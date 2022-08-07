string[] inputArray = { "hello", "2", "world", ":-)", "1234", "1567" };

// Медод для мечати массива
string PrintArray(string[] inputArray)
{
    return string.Join(", ", inputArray);
}

// Метод для подсчета строк в массиве длинной меньше или равных 3 символов
int CountStringInArray(string[] input)
{
    int len = inputArray.Length;
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < len; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            count++;
        }
    }
    return count;
}

// Метод для создания нового массива из строк длинной меньше или равных 3 символов, которые найдет во входном массиве
// ! в аргумент countWords передаем результат работы метода CountStringInArray !
string[] CreateNewArray(string[] inputArray, int countWords)
{
    int len = inputArray.Length;
    string[] outputArray = new string[countWords];
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < len; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }

    return outputArray;
}

PrintArray(inputArray);

string[] outputArray = CreateNewArray(inputArray, CountStringInArray(inputArray));

PrintArray(outputArray);
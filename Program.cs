string[] inputArray = { "hello", "2", "world", ":-)", "1234", "1567" };

// 
string PrintArray(string[] inputArray)
{
    return string.Join(",", inputArray);
}

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

// 
string[] FillNewArray(string[] inputArray, int countWords)
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
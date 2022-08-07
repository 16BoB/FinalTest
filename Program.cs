string[] inputArray = { "hello", "2", "world", ":-)", "1234", "1567" };

// Method for Printing an Array
string PrintArray(string[] inputArray)
{
    return string.Join(", ", inputArray);
}

// Method for counting strings in an array less than or equal to 3 characters long
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

// Method for creating a new array from strings less than or equal to 3 characters that it finds in the input array
// ! pass the result of the CountStringInArray method to the countWords argument !
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
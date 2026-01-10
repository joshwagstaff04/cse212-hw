public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Plan:
        // 1 Make a new array of size length
        //2 loop i from 0 to length -1
        //3 Each spot is number * (i + 1)
        //4 Reurn the array

        var result = new double[length];

        for (int i = 0; i < length; i++)

        {
            result[i] = number * (i + 1);
        }




        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //i need to figure out where the list should be split
        //everything at the end based on amount need to be moved to the front
        int splitIndex = data.Count - amount;

        //grab the two parts of the list
        //the first part stays in order and the second part gets moved to the front
        List<int> firstPart = data.GetRange(0, splitIndex);
        List<int> secondPart = data.GetRange(splitIndex, amount);

        //clear the list so it can be rebuilt
        data.Clear();

        //Put the end part first then the beginning part
        data.AddRange(secondPart);
        data.AddRange(firstPart);

    }
}

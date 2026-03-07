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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array of doubles with the specified length to hold the multiples.
        // Step 2: Use a loop to calculate the multiples of the number and store them in the array.
        // Step 3: Return the completed array of multiples.


        double[] result = new double[length]; // create an array of the specified length to hold the multiples
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // calculate the multiple and store it in the array

        }

        return result; // return the completed array of multiples
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine the number of elements in the list to ensure the rotation amount is valid.
        // Step 2: Use a loop to perform the rotation by moving the last element to
        //         the front of the list and removing it from the end, repeating this process for the specified amount.
        // Step 3: The list will be modified in place, so no return value is needed.
        // Step 4: Ensure that the amount is within the bounds of the list size to prevent unnecessary rotations.

        int count = data.Count; // get the number of elements in the list
        amount = amount % count; // ensure the amount is within the bounds of the list size

        // Perform the rotation
        for (int i = 0; i < amount; i++)
        {
            data.Insert(0, data[data.Count - 1]); // Move the last element to the front
            data.RemoveAt(data.Count - 1); // Remove the last element
        }
        
    }
}

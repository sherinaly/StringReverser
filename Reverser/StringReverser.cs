namespace Reverser
{
    class StringReverser
    {
        /// <summary>
        /// Reverse the order of words in the input string.
        /// </summary>
        /// <param name="inputStringToReverse">The inputStringToReverse.</param>
        /// <returns>System.String.</returns>
        public static string ReverseWordOrderInThisString(string inputStringToReverse)
        {
            var splitString = inputStringToReverse.Split();
            var n = splitString.Length;
            var reversed = "";
            for (var i = n - 1; i >= 0; i--)
                reversed = reversed + splitString[i] + " ";
            return reversed;
        }
    }
}
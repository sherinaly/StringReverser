namespace Reverser
{
    class Reverser
    {
        /// <summary>
        /// Reverses the order of the input string.
        /// </summary>
        /// <param name="inputStringToReverse">The inputStringToReverse.</param>
        /// <returns>System.String.</returns>
        public static string ReverseThisString(string inputStringToReverse)
        {
            var splitter = inputStringToReverse.Split();
            var n = splitter.Length;
            var reversed = "";
            for (var i = n - 1; i >= 0; i--)
                reversed = reversed + splitter[i] + " ";
            return reversed;
        }
    }
}
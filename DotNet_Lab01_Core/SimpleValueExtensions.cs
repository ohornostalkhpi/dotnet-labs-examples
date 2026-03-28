namespace DotNet_Lab01_Core
{
    public static class SimpleValueExtensions
    {
        // Extension for int: check if even
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
    }
}

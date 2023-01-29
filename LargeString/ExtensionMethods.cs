using LargeString.Abstractions;

namespace LargeString
{
    public static class ExtensionMethods
    {
        public static void Clear(this Result result)
        {
            result.Length = 0;
            result.Letter = char.MinValue;
        }
    }
}

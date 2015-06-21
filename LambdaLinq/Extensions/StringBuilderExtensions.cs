namespace LambdaLinq.Extensions
{
    using System.Text;
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            StringBuilder subStr = new StringBuilder();
            for (int i = startIndex; i < sb.Length; i++)
            {
                subStr.Append(sb[i]);
            }
            return subStr;
        }

        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int endIndex)
        {
            StringBuilder subStr = new StringBuilder();
            for (int i = startIndex; i < endIndex; i++)
            {
                subStr.Append(sb[i]);
            }
            return subStr;
        }

    }
}

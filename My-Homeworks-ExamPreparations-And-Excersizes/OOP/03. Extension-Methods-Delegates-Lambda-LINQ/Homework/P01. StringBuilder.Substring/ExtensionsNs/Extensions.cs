
namespace ExtensionsNs
{
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            string sbString = sb.ToString();

            string sbStringExtraction = sbString.Substring(startIndex, length);
            sb = new StringBuilder(sbStringExtraction);

            return sb;
        }
    }
}


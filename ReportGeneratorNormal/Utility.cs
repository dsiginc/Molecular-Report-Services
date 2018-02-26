using System.Collections.Generic;
namespace ReportGeneratorNormal
{
    public static class Utility
    {
        public static byte[] GetDictionaryValue(Dictionary<string, byte[]> ResultList, string keyValue)
        {
            byte[] item;
            if (!ResultList.TryGetValue(keyValue, out item))
                return null;
            return item;
        }
    }
}
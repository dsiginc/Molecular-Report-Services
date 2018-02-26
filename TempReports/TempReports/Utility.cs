using System.Collections.Generic;
namespace ReportGeneratorNormal
{
    public static class Utility
    {
        public static byte[] GetDictionaryValue(Dictionary<string, byte[]> ResultList, string keyValue)
        {
            return ResultList[keyValue];
        }
    }
}
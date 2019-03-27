using Molecular.DataAccess.ToxicologyAccessionService;
using ReportGenerator;
using System.Collections.Generic;
using System.IO;

namespace ReportGeneratorNormal
{
    public static class Utility
    {
        public static byte[] GetDictionaryValue(Dictionary<string, byte[]> ResultList, string keyValue)
        {
            byte[] item;
            if (!ResultList.TryGetValue(keyValue, out item))
            {
                item = File.ReadAllBytes(System.Configuration.ConfigurationManager.AppSettings["reportIconsFolder"].ToString() + "\\not_ordered_icon.png");
            }
            return item;
        }
        public static bool IsAdditionalTestsExist(List<CTR_ClinicalTestResult> testResults)
        {
            bool additionalTestsExist = false;
            if (testResults != null)
            {
                foreach(var item in testResults)
                {
                    if (item.ApprovedPanel == false)
                    {
                        additionalTestsExist = true;break;
                    }
                }
            }
            return additionalTestsExist;
        }
        public static bool IsTestResultsExist(List<CTR_ClinicalTestResult> testResults)
        {
            bool additionalTestsExist = false;
            if (testResults != null)
            {
                foreach (var item in testResults)
                {
                    if (item.ApprovedPanel != false)
                    {
                        additionalTestsExist = true; break;
                    }
                }
            }
            return additionalTestsExist;
        }
        public static bool IsUnexpectedResultsExist(IEnumerable<PrescribedDrug> drugs, string resultType="POS")
        {
            bool res = false;
            if (drugs != null)
            {
                foreach(var drug in drugs)
                {
                    if(drug.Result== resultType)
                    {
                        res = true;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
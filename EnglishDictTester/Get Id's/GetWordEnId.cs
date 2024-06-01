using EnglishDictTester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictTester.Get_Id_s
{
    public class GetWordEnId
    {
        public static EnglishDictTesterContext context = new EnglishDictTesterContext();
        //public static List<int?> lsEnWordIds = new List<int?>();

        public int? GetWordEnID(string wordEn)
        {
            var checkEnWords = context.WordEns?.Select(w => new { w.EnWord, w.WordEnId }).SingleOrDefault(w => w.EnWord == wordEn);
            int? enWordId = checkEnWords?.WordEnId;

            return enWordId;
        }
        //public List<int?> GetWordEnID(string wordEn)
        //{
        //    var checkEnWords = context.WordEns?.Select(w => new { w.EnWord, w.WordEnId }).Where(w => w.EnWord == wordEn);
        //    //int? enWordId = checkEnWord?.WordEnId;
        //    foreach (var enWord in checkEnWords!)
        //    {
        //        int? enWordId = enWord?.WordEnId;
        //        lsEnWordIds.Add(enWordId);
        //    }

        //    return lsEnWordIds.ToList();
        //}
    }
}

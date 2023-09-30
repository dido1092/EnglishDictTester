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

        public int? GetWordEnID(string wordEn)
        {
            var checkEnWord = context.WordEns?.Select(w => new { w.EnWord, w.WordEnId }).SingleOrDefault(w => w.EnWord == wordEn);
            int? enWordId = checkEnWord?.WordEnId;

            return enWordId;
        }
    }
}

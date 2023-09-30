using EnglishDictTester.Data;

namespace EnglishDictTester.Get_Id_s
{
    public class GetWordBgId
    {
        public static EnglishDictTesterContext context = new EnglishDictTesterContext();

        public int? GetWordBgID(string wordBg)
        {
            var checkBgWord = context.WordBgs?.Select(w => new { w.BgWord, w.WordBgId }).SingleOrDefault(w => w.BgWord == wordBg);
            int? bgWordId = checkBgWord?.WordBgId;

            return bgWordId;
        }
    }
}

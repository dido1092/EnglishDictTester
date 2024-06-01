using EnglishDictTester.Data;

namespace EnglishDictTester.Get_Id_s
{
    public class GetWordBgId
    {
        public static EnglishDictTesterContext context = new EnglishDictTesterContext();
        //public static List<int?> lsBgWordIds = new List<int?>();

        public int? GetWordBgID(string wordBg)
        {
            var checkBgWord = context.WordBgs?.Select(w => new { w.BgWord, w.WordBgId }).SingleOrDefault(w => w.BgWord == wordBg);
            int? bgWordId = checkBgWord?.WordBgId;

            return bgWordId;
        }
        //public List<int?> GetWordBgID(string wordBg)
        //{
        //    var checkBgWord = context.WordBgs?.Select(w => new { w.BgWord, w.WordBgId }).Where(w => w.BgWord == wordBg);
        //    //int? bgWordId = checkBgWord?.WordBgId;
        //    foreach (var bgWord in checkBgWord!)
        //    {
        //        int? bgWordId = bgWord?.WordBgId;
        //        lsBgWordIds.Add(bgWordId);
        //    }

        //    return lsBgWordIds.ToList();
        //}
    }
}

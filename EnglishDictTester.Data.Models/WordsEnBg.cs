using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictTester.Data.Models
{
    public class WordsEnBg
    {

        public int? WordBgId { get; set; }
        public int? WordEnId { get; set; }

        [ForeignKey(nameof(WordBgId))]
        public virtual WordBg? WordBg { get; set; }

        [ForeignKey(nameof(WordEnId))]
        public virtual WordEn? WordEn { get; set; }
    }
}

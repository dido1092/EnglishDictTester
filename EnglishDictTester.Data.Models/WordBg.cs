using EnglishDictTester.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictTester.Data.Models
{
    public class WordBg
    {
        public WordBg()
        {
            this.WordsEnBgs = new HashSet<WordsEnBg>();
        }

        [Key]
        public int? WordBgId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.WordBgMaxLength)]
        public string? BgWord { get; set; }

        public virtual ICollection<WordsEnBg>? WordsEnBgs { get; set; }
    }
}

using EnglishDictTester.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace EnglishDictTester.Data.Models
{
    public class WordEn
    {
        public WordEn()
        {
            this.WordsEnBgs = new HashSet<WordsEnBg>();
        }

        [Key]
        public int? WordEnId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.WordEnMaxLength)]
        public string? EnWord { get; set; }

        public string? Transcriptions { get; set; }

        public virtual ICollection<WordsEnBg>? WordsEnBgs { get; set; }

    }
}
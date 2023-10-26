using EnglishDictTester.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictTester.Data.Models
{
    public class Tests
    {
        [Key]
        public int? testId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.languageName)]
        public string? lngName { get; set; }

        [Required]
        public int test { get; set; }

        public int? bgId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.WordBgMaxLength)]
        public string? bgW { get; set; }

        public int? enId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.WordEnMaxLength)]
        public string? enW { get; set; }


        [Required]
        [MaxLength(ValidationConstants.Answer)]
        public string? answer { get; set; }

        [Required]
        public  DateTime dateTime { get; set; }

    }
}

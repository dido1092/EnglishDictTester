using EnglishDictTester.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDictTester
{
    public partial class frmWordGame : Form
    {
        EnglishDictTesterContext context = new EnglishDictTesterContext();
        Random rnd = new Random();
        public static string[] words = null!;
        public static int q = 0;
        public static int countScore = 0;
        public static int wordsCount = 0;
        public frmWordGame()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            q = 0;
            countScore = 0;
            int counter = 0;
            progressBar1.Minimum = 0;
            progressBar1.Value = 1;

            words = new string[int.Parse(textBoxNumberOfWords.Text)];

            wordsCount = words.Length;

            progressBar1.Maximum = words.Length;

            var enWords = context.WordEns?.Select(e => new { e.EnWord }).ToList();

            foreach (var word in enWords!)
            {
                if (counter == words.Length)
                {
                    break;
                }
                int index = rnd.Next(enWords!.Count - 1);
                words[counter] = enWords[index].EnWord!.ToString()!;
                counter++;
            }


            labelShuffleWord.Text = Scramble(words[0].ToString());
        }
        public static string Scramble(string s)
        {
            return new string(s.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string writeWord = textBoxWord.Text.ToUpper();
            q++;

            if (q >= wordsCount)
            {
                MessageBox.Show("Finish!");
                labelScore.Text = $"Score: {countScore}";
                return;
            }
            else
            {
                progressBar1.Value += 1;
            }
            if (words[q] == writeWord)
            {
                countScore++;
                labelScore.Text = $"Score: {countScore}";
            }

            labelShuffleWord.Text = Scramble(words[q].ToString());
            textBoxWord.Text = "";

            textBoxWord.Focus();
        }
    }
}

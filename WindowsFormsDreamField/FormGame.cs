using System;
using System.Windows.Forms;

namespace WindowsFormsDreamField
{
    public partial class FormGame : Form
    {
        string word = "стул";
        string template;
        int error = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        static string createTemplate(string s)
        {
            string newWord = "";
            for (int i = 0; i < s.Length; i++)
            {
                newWord += "*";
            }
            return newWord;
        }

        static bool isLetterInWord(char letter, string word, ref string template)
        {
            bool isExist = false;
            string newTemplate = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    newTemplate += letter;
                    isExist = true;
                }
                else
                {
                    newTemplate += template[i];
                }
            }
            template = newTemplate;
            return isExist;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            pictureBoxGallows.Load("images/p0.png");
            template = createTemplate(word);
            labelTemplate.Text = template;
        }

        private void buttonCheckLetter_Click(object sender, EventArgs e)
        {
            char letter = textBoxLetter.Text[0];
            bool isExistLetter = isLetterInWord(letter, word, ref template);
            if (isExistLetter)
            {
                labelTemplate.Text = template;
                MessageBox.Show("Есть такая буква в слове!");
            }
            else
            {
                error++;
                string fileNameImage = "images/p" + error.ToString() + ".png";
                pictureBoxGallows.Load(fileNameImage);
                MessageBox.Show("Нет такой буквы в слове!");
            }
        }
    }
}

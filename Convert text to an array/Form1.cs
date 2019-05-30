using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_text_to_an_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConvertButton_Click(object sender, EventArgs e)
        {
            String inputText = richTextBox1.Text.ToUpper();
            Char[] inputChars = inputText.ToCharArray();

            int i = 1;
            int x = 0;
            string outputText = "";
            while (inputText.Length > x-1)
            {

                outputText = outputText + "[" + getCharSafe(inputText.ToCharArray(), x) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 1) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 2) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 3) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 4) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 5) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 6) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 7) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 8) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 9) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 10) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 11) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 12) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 13) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 14) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 15) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 16) +
                    ", " + getCharSafe(inputText.ToCharArray(), x + 17) + "],\n";

                x = x + 17;
                i++;
            }
            richTextBox2.Text = outputText;
        }
        public string getCharSafe(Char[] input, int run)
        {
            if (run < input.Length)
            {
                if (input[run].ToString() == " ")
                {
                    return "_";
                }
                else
                    return input[run].ToString();
            }
            else return "_";
        }
    }

}

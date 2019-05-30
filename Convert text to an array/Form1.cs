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

                outputText = outputText + "["+ getCharSafe(inputText.ToCharArray(), x)+
                    ", " + getCharSafe(inputText.ToCharArray(), x +1) +
                    ", " + getCharSafe(inputText.ToCharArray(), x +2) +
                    ", " + getCharSafe(inputText.ToCharArray(), x +3) + "],\n";

                x = x + 4;
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

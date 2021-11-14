using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monoalphabetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String text = this.text.Text;
            char[] alphabetics = {'A', 'B', 'C', 'D', 'E', 'F'
                    , 'G', 'H', 'I', 'J', 'K', 'L'
                    , 'M', 'N', 'O', 'P', 'Q', 'R'
                    , 'S', 'T', 'U', 'V', 'W', 'X'
                    , 'Y', 'Z'};

            //String[] keys = {"M", "N", "O", "P", "Q", "R"
            //        , "G", "H", "I", "J", "K", "L"
            //        , "S", "T", "U", "V", "W", "X"
            //        ,"A", "B", "C", "D", "Y", "Z"
            //        , "E", "F"};
            String key = "MNOPGQRKJHISLTUVWXABCDYZEF";
            String encryptedText = "";
            //String k = String.Empty;

            //Dictionary<String, String> letters = new Dictionary<String, String> { };

            //for(int i=0; i < alphabetics.Length; i++)
            //{
            //    letters.Add(alphabetics[i], keys[i]);
            //}

            //for(int j = 0; j < text.Length; j++)
            //{
            //    foreach(KeyValuePair<String, String> letter in letters)
            //    {
            //        if (text[j] == letter[])
            //        {

            //        }
            //    }
            //}

            //text = text.ToUpper();

            foreach(char letter in text)
            {
                if(char.IsDigit(letter))
                {
                    MessageBox.Show("The text must be only alphabetics");
                    this.text.Focus();
                    this.text.Text = "Hello";
                    break;
                }
                bool checkLower = char.IsLower(letter);
                //MessageBox.Show(checkLower.ToString() + "\n" + letter);
                for (int i = 0; i < alphabetics.Length; i++)
                {
                    if (char.ToUpper(letter) == alphabetics[i])
                    {
                        if(checkLower)
                        {
                            encryptedText += char.ToLower(key[i]);
                            //MessageBox.Show(key[i].ToString().ToLower());
                        }
                        else
                        {
                            encryptedText += key[i];
                        }
                        break;
                    }
                    continue;
                }
            }
            //MessageBox.Show(encryptedText);
            this.encText.Text = encryptedText;
            this.encText.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text = this.text.Text;
            char[] alphabetics = {'A', 'B', 'C', 'D', 'E', 'F'
                    , 'G', 'H', 'I', 'J', 'K', 'L'
                    , 'M', 'N', 'O', 'P', 'Q', 'R'
                    , 'S', 'T', 'U', 'V', 'W', 'X'
                    , 'Y', 'Z'};

            String key = "MNOPGQRKJHISLTUVWXABCDYZEF";
            String decryptedText = "";

            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    MessageBox.Show("The text must be only alphabetics");
                    this.text.Focus();
                    break;
                }
                bool checkLower = char.IsLower(letter);
                for (int i = 0; i < key.Length; i++)
                {
                    if (char.ToUpper(letter) == key[i])
                    {
                        if (checkLower)
                        {
                            decryptedText += alphabetics[i].ToString().ToLower();
                        }
                        else
                        {
                            decryptedText += alphabetics[i];
                        }
                        break;
                    }
                    continue;
                }
            }
            this.decText.Text = decryptedText;
            this.decText.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Lab06_Bai02 : Form
    {
        public Lab06_Bai02()
        {
            InitializeComponent();
        }

        readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void button_encode_Click(object sender, EventArgs e)
        {
            string plainText = richTextBox_input.Text;
            string key = textBox_key.Text.ToUpper();
            string cipherText = "";
            int keyIndex = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    cipherText += ' ';
                    continue;
                }
                bool isLower = char.IsLower(plainText[i]);
                int index = alphabet.IndexOf(char.ToUpper(plainText[i]));
                int keyCharIndex = alphabet.IndexOf(key[keyIndex]);
                var newIndex = (index + keyCharIndex) % alphabet.Length;
                cipherText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
                keyIndex = (keyIndex + 1) % key.Length;
            }
            richTextBox_encode.Text = cipherText;
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            string cipherText = richTextBox_encode.Text;
            string key = textBox_key.Text.ToUpper();
            string plainText = "";
            int keyIndex = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    plainText += ' ';
                    continue;
                }
                bool isLower = char.IsLower(cipherText[i]);
                int index = alphabet.IndexOf(char.ToUpper(cipherText[i]));
                int keyCharIndex = alphabet.IndexOf(key[keyIndex]);
                var newIndex = (index - keyCharIndex + alphabet.Length) % alphabet.Length;
                plainText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
                keyIndex = (keyIndex + 1) % key.Length;
            }
            richTextBox_decode.Text = plainText;
        }

        private void textBox_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập số vào TextBox
            }
        }
    }
}

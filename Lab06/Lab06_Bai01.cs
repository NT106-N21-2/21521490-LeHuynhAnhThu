namespace Lab06
{
    public partial class Lab06_Bai01 : Form
    {
        public Lab06_Bai01()
        {
            InitializeComponent();
        }

        readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void button_encode_Click(object sender, EventArgs e)
        {
            string plainText = richTextBox_input.Text;
            string cipherText = "";
            int shift = int.Parse(textBox_shift.Text);

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    cipherText += ' ';
                    continue;
                }

                bool isLower = char.IsLower(plainText[i]);
                int index = alphabet.IndexOf(char.ToUpper(plainText[i]));
                var newIndex = (index + shift) % alphabet.Length;
                cipherText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
            }
            richTextBox_encode.Text = cipherText;
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            string cipherText = richTextBox_encode.Text;
            string plainText = "";
            int shift = int.Parse(textBox_shift.Text);

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    plainText += ' ';
                    continue;
                }

                bool isLower = char.IsLower(cipherText[i]);
                int index = alphabet.IndexOf(char.ToUpper(cipherText[i]));
                var newIndex = index - shift >= 0 ? index - shift : alphabet.Length - index - shift;
                plainText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
            }
            richTextBox_decode.Text = plainText;
        }
    }
}
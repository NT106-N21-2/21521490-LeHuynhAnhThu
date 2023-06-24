namespace Lab06
{
    public partial class Lab06_Bai01 : Form
    {
        public Lab06_Bai01()
        {
            InitializeComponent();
        }

        readonly string alphabet = "aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()";

        private void button_encode_Click(object sender, EventArgs e)
        {
            string plainText = richTextBox_input.Text;
            string cipherText = "";
            int shift = int.Parse(textBox_shift.Text);

            for (int i = 0; i < plainText.Length; i++)
            {
                char currentChar = plainText[i];

                if (!alphabet.Contains(currentChar.ToString()))
                {
                    // Nếu ký tự không thuộc bảng chữ cái được sử dụng trong chương trình, thì bỏ qua nó
                    cipherText += currentChar;
                    continue;
                }

                bool isLower = char.IsLower(currentChar);
                int index = alphabet.IndexOf(char.ToLower(currentChar));
                int newIndex = (index + shift) % alphabet.Length;
                char newChar = alphabet[newIndex];

                if (isLower)
                {
                    newChar = char.ToLower(newChar);
                }

                cipherText += newChar;
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
                char currentChar = cipherText[i];

                if (!alphabet.Contains(currentChar.ToString()))
                {
                    // Nếu ký tự không thuộc bảng chữ cái được sử dụng trong chương trình, thì bỏ qua nó
                    plainText += currentChar;
                    continue;
                }

                bool isLower = char.IsLower(currentChar);
                int index = alphabet.IndexOf(char.ToLower(currentChar));
                int newIndex = index - shift;

                if (newIndex < 0)
                {
                    newIndex += alphabet.Length;
                }

                char newChar = alphabet[newIndex];

                if (isLower)
                {
                    newChar = char.ToLower(newChar);
                }

                plainText += newChar;
            }

            richTextBox_decode.Text = plainText;
        }

        private void textBox_shift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '0' && textBox_shift.TextLength == 0))
            {
                e.Handled = true;
            }
        }
    }
}
using System.Linq;

namespace LAB
{
    class BCipher : Chiper, ICipher
    {
        private int i;

        public BCipher(int i)
        {
            this.i = i;
        }

        public string Encode(string text)
        {
            string output = "";
            foreach (char letter in text)
            {
                if (alphabet_eng.Contains(letter))
                {
                    output += alphabet_eng[alphabet_eng.IndexOf(letter) + i];
                }
                else if (alphabet_ru.Contains(letter))
                {
                    output += alphabet_ru[alphabet_ru.IndexOf(letter) + i];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }
        public string Decode(string detext)
        {
            string output = "";
            foreach (char letter in detext)
            {
                if (alphabet_eng.Contains(letter))
                {
                    output += alphabet_eng[alphabet_eng.IndexOf(letter) - i];
                }
                else if (alphabet_ru.Contains(letter))
                {
                    output += alphabet_ru[alphabet_ru.IndexOf(letter) - i];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }
    }
}
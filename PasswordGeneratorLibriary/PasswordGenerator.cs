using System.Text;
using PasswordGeneratorLibriary.Extension;

namespace PasswordGeneratorLibriary
{
    public class PasswordGenerator
    {
        private readonly Random RANDOM = new Random();
        private string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private string SpecialAlphabet = "!@$%&";
        private int Lenght = 10;
        private int SpecialCharPersent = 10;

        public PasswordGenerator()
        {

        }

        public PasswordGenerator(int lenght)
        {
            Lenght = lenght;
        }

        public PasswordGenerator(int lenght, string alphabet, string specialAlphabet)
        {
            Lenght = lenght;
            Alphabet = alphabet;
            SpecialAlphabet = specialAlphabet;
        }

        public PasswordGenerator(int lenght, string alphabet, string specialAlphabet, int specialCharPersent)
        {
            Lenght = lenght;
            Alphabet = alphabet;
            SpecialAlphabet = specialAlphabet;
            SpecialCharPersent = specialCharPersent;
        }

        public string Generate(int length, int specialCharPersent)
        {
            var sb = new StringBuilder();

            specialCharPersent.ValidatePersent();

            for (int i = 0; i < length; i++)
            {
                if (RANDOM.Next(0, 100) < specialCharPersent)
                {
                    sb.Append(SpecialAlphabet[RANDOM.Next(0, SpecialAlphabet.Length)]);
                }
                else
                {
                    sb.Append(Alphabet[RANDOM.Next(0, Alphabet.Length)]);
                }
            }

            return sb.ToString();
        }
        public string Generate(int length)
        {
            var sb = new StringBuilder();

            SpecialCharPersent.ValidatePersent();

            for (int i = 0; i < length; i++)
            {
                if (RANDOM.Next(0, 100) < SpecialCharPersent)
                {
                    sb.Append(SpecialAlphabet[RANDOM.Next(0, SpecialAlphabet.Length)]);
                }
                else
                {
                    sb.Append(Alphabet[RANDOM.Next(0, Alphabet.Length)]);
                }
            }

            return sb.ToString();
        }
        public string Generate()
        {
            var sb = new StringBuilder();

            SpecialCharPersent.ValidatePersent();

            for (int i = 0; i < Lenght; i++)
            {
                if (RANDOM.Next(0, 100) < SpecialCharPersent)
                {
                    sb.Append(SpecialAlphabet[RANDOM.Next(0, SpecialAlphabet.Length)]);
                }
                else
                {
                    sb.Append(Alphabet[RANDOM.Next(0, Alphabet.Length)]);
                }
            }

            return sb.ToString();
        }
    }
}
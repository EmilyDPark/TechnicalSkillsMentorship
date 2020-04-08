using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkillsMentorship
{
    class _4_CaesarCipher
    {
        // April 8, 2020

        // Caesar Cipher is one of the earlist and simplest encryption techniques.
        // To encrypt a message, we shift the alphabets of the message by a fixed position or key.

        // For example, if message is ABC, and we shift each character by 3 characters, we will get DEF.
        // Here key is 3.

        // TODO: Given a message and key, compute its Caesar Cipher

        // Extra TO DO: You can also encrypt the numbers.
        // Do not encrypt special characters and white spaces.

        // message: Pa$$w0rd
        // encryption key: 6
        // Encrypted Message: Vg$$c6xj

        // Advanced Example with numbers
        // message: THE SHIPS WILL SAIL AT 0351.
        // encryption key: 2
        // Encrypted Message: VJG UJKRU YKNN UCKN CV 2573.

        // Another example with letters numbers and special character
        // message: RETREAT!! AT 0957
        // encryption key: 5
        // Encrypted Message: WJYWJFY!! FY 5402

        // Key is from 0 to max int


        // Don't know how to convert to ASCII values
        public string CaesarCipher(string message, int key)
        {
            var encrypted = new StringBuilder();
            var letters = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    byte ascii = Encoding.Default.GetBytes("c")[0];
                    Console.WriteLine(ascii);

                    if (char.IsUpper(c))
                    {
                        var lower = GetNewChar(char.ToLower(c), key, letters);
                        encrypted.Append(char.ToUpper(lower));
                    }
                    else
                    {
                        encrypted.Append(GetNewChar(c, key, letters));
                    }
                }
                else if (char.IsNumber(c))
                    encrypted.Append(GetNewChar(c, key, numbers));
                else
                    encrypted.Append(c);
            }

            return encrypted.ToString();
        }

        public char GetNewChar(char c, int key, char[] valid)
        {
            var newIndex = Array.IndexOf(valid, c) + key;
            while (newIndex >= valid.Length)
            {
                newIndex -= valid.Length;
            }
            return valid[newIndex];
        }

        // Bhusan's code
        char EncryptLetter(char c, int key)
        {
            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)(((c + key - d) % 26) + d);
        }

    } // _4_CaesarCipher class

} // TechnicalSkillsMentorship namespace

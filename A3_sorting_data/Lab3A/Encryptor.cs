/*I, Trung Kien Bui, 000356049 certify that this material is my original work. No other person's work has been used without due acknowledgement. 
    Data created: October 31, 2023
    Purpose: This program is created to read data from text file, decrypt some info and display them. obstacles: "-----", '|', '\n', BOOK and MOVIE summary encrypted. ROT13 Wikipedia
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// This class is responsible for Decrypt method, used to decrypt Book and Movie summary
    /// </summary>
    internal class Encryptor : IEncryptable
    {
        // string message to return book and movie summary as a string
        public string Message;
        /// <summary>
        /// Encryptor construction
        /// </summary>
        /// <param name="message"></param>
        public Encryptor(string message)
        {
            Message = message;
        }
        /// <summary>
        /// Encrypt method
        /// </summary>
        /// <returns></returns>
        public string Encrypt()
        {
            return "";
        }
        /// <summary>
        /// Decrypt method
        /// </summary>
        /// <returns>Decrypted summary</returns>
        public string Decrypt()
        {
            // ref:
            // https://www.techieclues.com/blogs/converting-rot13-encoded-strings-to-normal-strings-in-csharp

            string encodedStr = Message;
            string decodedStr = "";

            foreach (char c in encodedStr)
            {
                int asciiCode = (int)c;

                if (char.IsLetter(c))
                {

                    int shiftedAsciiCode = asciiCode + 13;

                    if (c >= 'a' && c <= 'z')
                    {
                        if (shiftedAsciiCode > 'z')
                        {
                            shiftedAsciiCode -= 26;
                        }
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        if (shiftedAsciiCode > 'Z')
                        {
                            shiftedAsciiCode -= 26;
                        }
                    }

                    decodedStr += (char)shiftedAsciiCode;
                }
                else
                {
                    decodedStr += c;
                }
            }

            // Console.WriteLine("\t>>>" + decodedStr);
            return decodedStr;
        }
    }
}

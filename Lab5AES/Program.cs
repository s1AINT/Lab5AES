using System;
using System.Text;

namespace Lab5AES
{
    class Program
    {
        static void Main(string[] args)
        {
            AES aes = new AES(Encoding.UTF8.GetBytes("1234password1234"));

            byte[] text = Encoding.UTF8.GetBytes("Text 123 Text 12");
            if (aes.Encrypt(text, ref text))
            {
                Console.WriteLine("Зашифрований текст = " + Encoding.UTF8.GetString(text));

                aes.Decrypt(text, ref text);
                Console.WriteLine("Розшифрований текст = " + Encoding.UTF8.GetString(text));
            }
            else
                Console.WriteLine("Невірні передані дані!");
        }
    }
}

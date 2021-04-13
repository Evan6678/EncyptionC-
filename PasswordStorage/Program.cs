using System;
using System.Drawing;
using Console = Colorful.Console;

using PasswordStorage.Formatters;
using EncryptStore.BLL;

namespace PasswordStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TextDisplayers displayer = new TextDisplayers();
            PasswordEncryptDecrypt accessor = new PasswordEncryptDecrypt();

            displayer.printHeader(Color.Green, Color.Yellow);
            

        }
    }
}

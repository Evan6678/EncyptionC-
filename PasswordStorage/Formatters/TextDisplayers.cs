using System;
using System.Drawing;
using Console = Colorful.Console;

namespace PasswordStorage.Formatters
{
    class TextDisplayers
    {
        /// <summary>
        /// Function to print a seperator line
        /// </summary>
        /// <param name="seperatorColor">System.Drawings Color enum</param>
        public void printSeperator(Color seperatorColor)
        {
            Console.WriteLine("===================================================", seperatorColor);
        }

        /// <summary>
        /// Print the inital header for the application
        /// </summary>
        /// <param name="textColor">System.Drawings Color enum</param>
        /// <param name="seperatorColor">System.Drawings Color enum</param>
        public void printHeader(Color textColor, Color seperatorColor)
        {
            printSeperator(seperatorColor);
            Console.WriteLine("Welcome to Password-Store", textColor);
            Console.WriteLine("Author: Evan Stewart", textColor);
            printSeperator(seperatorColor);

            Console.WriteLine("\nSelect passwords file to begin...", textColor);
        }

        /// <summary>
        /// Print Main menue options
        /// </summary>
        /// <param name="textColor">System.Drawings Color enum</param>
        public void printMainOptions(Color textColor)
        {
            Console.WriteLine("1 - Output Passowords", textColor);
            Console.WriteLine("2 - Create new Passoword", textColor);
            Console.WriteLine("3 - Delete Password", textColor);
            Console.WriteLine("4 - Update Passoword", textColor);
        }
    }
}

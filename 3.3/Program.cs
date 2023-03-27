using System;

namespace PW3_3
{
    class SqlCommand
    {
        private string commandText;

        public string CommandText
        {
            get { return commandText.ToUpper(); }
            set { commandText = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand cmd = new SqlCommand();

            Console.Write("Введи SQL запрос: ");
            cmd.CommandText = Console.ReadLine();

            Console.WriteLine("Ваш запрос: {0}", cmd.CommandText);
        }
    }
}

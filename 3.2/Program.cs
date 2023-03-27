using System;

namespace PW3_2
{
    class SmsMessage
    {
        private string messageText;
        private decimal price;

        public string MessageText
        {
            get { return messageText; }
            set
            {
                messageText = value;
                CalculatePrice();
            }
        }

        public decimal Price
        {
            get { return price; }
        }

        public int WordCount
        {
            get { return MessageText.Split(new char[] { ' ', '.', ',', ';', ':', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length; }
        }

        public SmsMessage(string messageText)
        {
            MessageText = messageText;
        }

        private void CalculatePrice()
        {
            int messageLength = MessageText.Length;
            if (messageLength <= 65)
            {
                price = 1.5m;
            }
            else if (messageLength <= 250)
            {
                int additionalChars = messageLength - 65;
                price = 1.5m + additionalChars * 0.5m;
            }
            else
            {
                price = 1.5m + (250 - 65) * 0.5m;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage message1 = new SmsMessage("лалала привет окей");
            Console.WriteLine($"Текст 1: {message1.MessageText} (слов: {message1.WordCount}, цена: {message1.Price})");

            SmsMessage message2 = new SmsMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, metus eget varius rutrum, ipsum tellus luctus turpis");
            Console.WriteLine($"Текст 2: {message2.MessageText} (слов: {message2.WordCount}, цена: {message2.Price})");
        }
    }
}

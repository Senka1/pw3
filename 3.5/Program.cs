using System;

namespace PW3_5
{
    class SmsMessage
    {
        private string messageText;
        private decimal price;
        private int maxMessageLength;
        private decimal initialCost;
        private decimal costPerChar;

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

        public SmsMessage(string messageText, int maxMessageLength, decimal initialCost, decimal costPerChar)
        {
            this.messageText = messageText;
            this.maxMessageLength = maxMessageLength;
            this.initialCost = initialCost;
            this.costPerChar = costPerChar;

            CalculatePrice();
        }

        private void CalculatePrice()
        {
            int messageLength = MessageText.Length;

            if (messageLength <= maxMessageLength)
            {
                price = initialCost;
            }
            else
            {
                int additionalChars = messageLength - maxMessageLength;
                price = initialCost + additionalChars * costPerChar;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage message1 = new SmsMessage("лалала привет окей", 65, 1.5m, 0.5m);
            Console.WriteLine($"Текст 1: {message1.MessageText} (слов: {message1.WordCount}, цена: {message1.Price})");

            SmsMessage message2 = new SmsMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor," +
                " metus eget varius rutrum, ipsum tellus luctus turpis", 250, 1.5m, 0.5m);
            Console.WriteLine($"Текст 2: {message2.MessageText} (слов: {message2.WordCount}, цена: {message2.Price})");
        }
    }
}

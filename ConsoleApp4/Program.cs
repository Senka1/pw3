namespace PW3_1
{
    class Color
    {
        private int red;
        private int green;
        private int blue;

        public int Red
        {
            get { return red; }
            set { red = NormalizeColorValue(value); }
        }
        public int Green
        {
            get { return green; }
            set { green = NormalizeColorValue(value); }
        }
        public int Blue
        {
            get { return blue; }
            set { blue = NormalizeColorValue(value); }
        }

        public Color() { }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public void DisplayColor()
        {
            Console.WriteLine($"{red}, {green}, {blue}");
        }

        private int NormalizeColorValue(int colorValue)
        {

            if (colorValue > 255)
            {
                return 255;
            }
            if (colorValue < 0)
            {
                return 0;
            }

            return colorValue;
        }

    }
    internal class Program
    {
        static void Main()
        {
            Color Orange = new Color(255, 165, 0);
            Orange.DisplayColor();

            Color Yellow = new Color();
            Yellow.Red = 255;
            Yellow.Green = 255;
            Yellow.Blue = 0;
            Yellow.DisplayColor();
        }
    }
}

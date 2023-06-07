namespace conversion
{
    public class program
    {
        private static void Main(string[] args)
        {
            // Implicit Conversion
            int Num1 = 254;
            double Num2 = Num1;
            Console.WriteLine("Implicit Conversion: " + Num2);

            // Explicit Conversion 
            double Num3 = 10.5;
            int Num4 = (int)Num3;
            Console.WriteLine("Explicit Conversion (Casting): " + Num4);

            // Parsing
            string myParseString = "3.14";
            double myParsedDouble = double.Parse(myParseString);
            Console.WriteLine("Parsing: " + myParsedDouble);

            // TryParse
            Console.WriteLine("Enter a String");
            string myTryParseString = Console.ReadLine();
            int myTryParsedInt;
            bool success = int.TryParse(myTryParseString, out myTryParsedInt);
            if (success)
            {
                Console.WriteLine("TryParse: Conversion successful, value = " + myTryParsedInt);
            }
            else
            {
                Console.WriteLine("TryParse: Conversion failed");
            }

            // Boxing and Unboxing
            int myBoxedInt = 20;
            object myObject = myBoxedInt;
            int myUnboxedInt = (int)myObject;
            Console.WriteLine("Boxing and Unboxing: " + myUnboxedInt);

            // Conversion using Convert class
            string myString = "123";
            int myConvertedInt = Convert.ToInt32(myString);
            Console.WriteLine("Conversion using Convert class: " + myConvertedInt);

            char a = 'k';
            byte b = Convert.ToByte(a);
            Console.WriteLine("Char To byte " + b);

            int c = int.Parse(Console.ReadLine());
            char d = Convert.ToChar(c);
            Console.WriteLine("Byte to Char: " + d); 
        }
    }
}
namespace conversion
{
    public class conversion
    {
        public void code()
        {
            // Implicit Conversion
            int Num1 = 254;
            double Num2 = Num1;
            Console.WriteLine("Implicit Conversion: " + Num2);

            float myFloat = 3.14f;
            double myDouble = myFloat;
            Console.WriteLine(myDouble);

            var aaa = 889.878f;
            Console.WriteLine(aaa.GetType());

            Console.WriteLine(double.MaxValue);

            // Explicit Conversion
            double Num3 = 10.5;
            int Num4 = (int)Num3;
            Console.WriteLine("Explicit Conversion (Casting): " + Num4);

            int IntNum1 = 100;
            byte ByteNum1 = (byte)IntNum1;
            Console.WriteLine($"Original Value:{IntNum1} and Converted Value:{ByteNum1}");

            int IntNum2 = 500;
            byte ByteNum2 = (byte)IntNum2;
            Console.WriteLine($"Original Value:{IntNum2} and Converted Value:{ByteNum2}");

            /*string str = "100";
            int i1 = (int)str;*/

            // Parsing
            string myParseString = "3.14";
            double myParsedDouble = double.Parse(myParseString);
            Console.WriteLine("Parsing: " + myParsedDouble);

            string numberString = "123";
            int number = int.Parse(numberString);
            Console.WriteLine("Parsed integer: " + number);

            string dateString = "2023-06-07";
            DateTime date = DateTime.Parse(dateString);
            Console.WriteLine("Parsed date: " + date.ToString("yyyy-MM-dd"));

            // TryParse
            Console.WriteLine("Enter a value");
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

            string input = "true";
            bool result;
            if (bool.TryParse(input, out result))
            {
                Console.WriteLine("TryParse: Conversion successful, value = " + result);
            }
            else
            {
                Console.WriteLine("Parsing failed. Invalid input.");
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

            string str = "100";
            int i1 = Convert.ToInt32(str);
            Console.WriteLine("Original value str: {0} and Converted Value i1: {1}", str, i1);

            double d1 = 123.45;
            int i2 = Convert.ToInt32(d1);
            Console.WriteLine("Original value d: {0} and Converted Value i2:{1}", d, i2);

            float f = 45.678F;
            string str2 = Convert.ToString(f);
            Console.WriteLine($"Original value f: {f} and Converted Value str2:{str2}");
        }

       
     /*   public static int wholenum(double input, out double fraction)
        {
            fraction = input - (int)input;
            return (int)input;
        }

        public static void Fraction(double input, out double WholeNo, out double fract)
        {
            WholeNo = (int)input;
            fract = input - WholeNo;
        }*/

    }

    class program
    {
        public static void Main(string[] args)
        {
            /*conversion obj = new conversion();
            obj.code();*/

            double myinput = 10.3452;
            double fract;
            int wholenumber;

            wholenumber = wholenum(myinput, out fract);
            Console.WriteLine(fract);
            Console.WriteLine(wholenumber);

            Fraction(myinput, out wholenumber, out fract);
            Console.WriteLine(fract);
            Console.WriteLine(wholenumber);

            

        }
        public static int wholenum(double input, out double fraction)
        {
            fraction = input - (int)input;
            return (int)input;
        }
        public static void Fraction(double input, out int WholeNo, out double fract)
        {
            WholeNo = (int)input;
            fract = input - WholeNo;
        }
    }
}
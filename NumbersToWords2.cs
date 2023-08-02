class NumbersToWords2
{
    static void Main(string[] args)
    {
        string textNumber;
        int i;

        // test some random groups of numbers
        for (i = -1; i < 109; i++)
        {
            textNumber = ConvertNumberToText(i);
            Console.WriteLine(i + "\t" + textNumber);            
        }

        for (i = 10000; i < 11003; i++)
        {
            textNumber = ConvertNumberToText(i);
            Console.WriteLine(i + "\t" + textNumber);
        }

        for (i = 100000; i < 100010; i++)
        {
            textNumber = ConvertNumberToText(i);
            Console.WriteLine(i + "\t" + textNumber);
        }
    }

    public static string ConvertNumberToText(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + ConvertNumberToText(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += ConvertNumberToText(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ConvertNumberToText(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ConvertNumberToText(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }
}
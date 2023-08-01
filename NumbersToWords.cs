class NumbersToWords
{
    static void Main(string[] args)
    {
        string result;
        int i;

        // test some random groups of numbers
        for (i = -1; i < 109; i++)
        {
            if (ConvertNumberToText(i, out result) == true)
            {
                Console.WriteLine(i + "\t" + result);
            }
        }

        for (i = 10000; i < 11003; i++)
        {
            if (ConvertNumberToText(i, out result) == true)
            {
                Console.WriteLine(i + "\t" + result);
            }
        }

        for (i = 100000; i < 100010; i++)
        {
            if (ConvertNumberToText(i, out result) == true)
            {
                Console.WriteLine(i + "\t" + result);
            }
        }
    }

    static bool ConvertNumberToText(int num, out string result)
    {
        string tempString = "";
        int thousands;
        int temp;
        result = "";

        if (num < 0 || num > 100000)
        {
            System.Console.WriteLine(num + " \tNot Supported");
            return false;
        }

        if (num == 0)
        {
            System.Console.WriteLine(num + " \tZero");
            return false;
        }

        if (num < 1000)
        {
            HelperConvertNumberToText(num, out tempString);
            result += tempString;
        }
        else
        {
            thousands = num / 1000;
            temp = num - thousands * 1000;
            HelperConvertNumberToText(thousands, out tempString);
            result += tempString;
            result += "Thousand ";
            HelperConvertNumberToText(temp, out tempString);
            result += tempString;
        }

        return true;
    }

    static bool HelperConvertNumberToText(int num, out string buf)
    {
        string[] onesSet = {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
          };

        string[] tensSet = {
              "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety", "Hundred"
          };

        string result = "";
        buf = "";
        int single, tens, hundreds;

        if (num > 1000)
            return false;

        hundreds = num / 100;
        num = num - hundreds * 100;

        if (num < 20)
        {
            tens = 0; // special case
            single = num;
        }
        else
        {
            tens = num / 10;
            num = num - tens * 10;
            single = num;
        }

        result = "";

        if (hundreds > 0)
        {
            result += onesSet[hundreds - 1];
            result += " Hundred ";
        }

        if (tens > 0)
        {
            result += tensSet[tens - 1];
            result += " ";
        }

        if (single > 0)
        {
            result += onesSet[single - 1];
            result += " ";
        }

        buf = result;
        return true;
    }
}
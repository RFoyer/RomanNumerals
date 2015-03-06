using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral
{
    public class Encoder
    {

        // Choice 1: normal (easiest) way. 

        Dictionary<int, string> romanKey = new Dictionary<int, string>() {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string ToRoman(int number)
        {

            string romanNumeral = "";

            while (number >= 1)
            {
                foreach (KeyValuePair<int, string> kvp in romanKey)
                {
                    if (number >= kvp.Key)
                    {
                        romanNumeral += kvp.Value;
                        number -= kvp.Key;
                        break;
                    }
                }
            }

            return romanNumeral;
        }

        // Choice 2 (my idea): build numeral one digit at a time from right to left, use Insert method.

        //string[] tallyNumerals = { "I", "X", "C", "M" };
        //string[] fiveNumerals = { "V", "L", "D" };

        //public string ToRoman(int number)
        //{

        //    string numberAsRoman = "";
        //    string numberAsString = number.ToString();

        //    for (int i = 0; i < numberAsString.Length; i++)
        //    {
        //        int currentDigitAsInt = Int32.Parse(numberAsString[numberAsString.Length - 1 - i].ToString());
        //        string currentDigitAsRoman = "";

        //        if (currentDigitAsInt == 9)
        //        {
        //            currentDigitAsRoman += tallyNumerals[i] + tallyNumerals[i + 1];
        //            currentDigitAsInt -= 9;
        //        }

        //        if (currentDigitAsInt >= 5)
        //        {
        //            currentDigitAsRoman += fiveNumerals[i];
        //            currentDigitAsInt -= 5;
        //        }

        //        if (currentDigitAsInt == 4)
        //        {
        //            currentDigitAsRoman += tallyNumerals[i] + fiveNumerals[i];
        //        }

        //        if (currentDigitAsInt <= 3)
        //        {
        //            for (int j = 0; j < currentDigitAsInt; j++)
        //            {
        //                currentDigitAsRoman += tallyNumerals[i];
        //            }
        //        }

        //        numberAsRoman = numberAsRoman.Insert(0, currentDigitAsRoman);

        //    }

        //    return numberAsRoman;
        //}

        // Choice 3 (my idea): build numeral from left to right, but have to use indexConverter to find starting index on the string arrays.

        //string[] tallyNumerals = { "M", "C", "X", "I" };
        //string[] fiveNumerals = { "", "D", "L", "V" };
        //int[] indexConverter = { 3, 2, 1, 0 };

        //public string ToRoman(int number)
        //{

        //    string numberAsRoman = "";
        //    string numberAsString = number.ToString();
        //    int startingIndex = indexConverter[numberAsString.Length - 1];

        //    for (int i = 0; i < numberAsString.Length; i++)
        //    {
        //        int currentDigitAsInt = Int32.Parse(numberAsString[0 + i].ToString());
        //        string currentDigitAsRoman = "";

        //        if (currentDigitAsInt == 9)
        //        {
        //            currentDigitAsRoman += tallyNumerals[startingIndex + i] + tallyNumerals[startingIndex + i - 1];
        //            currentDigitAsInt -= 9;
        //        }

        //        if (currentDigitAsInt >= 5)
        //        {
        //            currentDigitAsRoman += fiveNumerals[startingIndex + i];
        //            currentDigitAsInt -= 5;
        //        }

        //        if (currentDigitAsInt == 4)
        //        {
        //            currentDigitAsRoman += tallyNumerals[startingIndex + i] + fiveNumerals[startingIndex + i];
        //        }

        //        if (currentDigitAsInt <= 3)
        //        {
        //            for (int j = 0; j < currentDigitAsInt; j++)
        //            {
        //                currentDigitAsRoman += tallyNumerals[startingIndex + i];
        //            }
        //        }

        //        numberAsRoman += currentDigitAsRoman;

        //    }

        //    return numberAsRoman;
        //}

        // Choice 4: Mike Harris' REPL one-liner.

        //public Func<int, string> ToRoman = (number) =>
        //    new Dictionary<int, string> {
        //    { 1000, "M" },
        //    { 900, "CM" },
        //    { 500, "D" },
        //    { 400, "CD" },
        //    { 100, "C" },
        //    { 90, "XC" },
        //    { 50, "L" },
        //    { 40, "XL" },
        //    { 10, "X" },
        //    { 9, "IX" },
        //    { 5, "V" },
        //    { 4, "IV" },
        //    { 1, "I" } //this last dictionary element is not actually necessary
        //}.Aggregate(new string('I', number), (m, _) => m.Replace(new string('I', _.Key), _.Value));

    }
}

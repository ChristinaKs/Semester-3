using System;

namespace KallasChristinaAssingment03_Restarted
{
    class HugeInteger
    {
        // Create the array
        private int[] numbers = new int[40];


        // Create the input method 
        public void Input(string stringInput)
        {
            // change the length of the array
            numbers = new int[stringInput.Length];

            char[] charArr = stringInput.ToCharArray(); // make it a charArray

            for (int i = 0; i < stringInput.Length; i++) // loop through to convert it
            {
                numbers[i] = charArr[i] - '0';
            }
        }


        // ToString method to iterate through a charArray and turn into a string
        public override string ToString()
        {
            string result = "";

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                result = numbers[i] + result;
            }
            return result;
        }

        //method to reverse string to do arithmetic operations (used in subtraction)
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }

        // method to calculate which string is smaller (used in subtraction)
        static bool IsSmaller(string str1, string str2)
        {
            // Calculate lengths of both string
            int n1 = str1.Length, n2 = str2.Length;

            if (n1 < n2)
            { // if 1 < 2 return true
                return true;
            }

            if (n1 > n2)
            { // if 1 > 2 return false
                return false;
            }

            for (int i = 0; i < n1; i++)
            { // iterate through and find which numeric value is smaller
                if (str1[i] < str2[i])
                { // return true if digit at i of 1 < digit at i of 2
                    return true;
                }
                else if (str1[i] > str2[i])
                { // return false if digit at i of 1 > digit at i of 2
                    return false;
                }
            }

            // default
            return false;
        }

        // Create IsZero() method
        public bool IsZero()
        {
            HugeInteger zeroValue = new HugeInteger();
            zeroValue.Input("0");

            // use IsEquals() method to check if = 0
            if (this.IsEquals(zeroValue))
            {
                return true; // return true if zero
            }
            else
            {
                return false; // else return false
            }
        }

        // Create IsEquals method
        public bool IsEquals(HugeInteger hugeInt)
        {
            String str1 = hugeInt.ToString().TrimStart('0');
            String str2 = this.ToString().TrimStart('0');

            return str1.Equals(str2);
        }

        // Create IsNotEquals() method
        public bool IsNotEquals(HugeInteger hugeInt)
        {
            String str1 = hugeInt.ToString().TrimStart('0');
            String str2 = this.ToString().TrimStart('0');

            return !str1.Equals(str2); // return the opposite of when theyre equals
        }

        // Create IsGreaterThan() method
        public bool IsGreaterThan(HugeInteger hugeInt)
        {
            string str = this.ToString();
            string str1 = hugeInt.ToString();
                
            str = str.TrimStart('0'); // Trimstart() found tutorial online - used to eliminate occurances in beginning of string object
            str1 = str1.TrimStart('0');

            if (str.Length > str1.Length) // if lenght of 1 is bigger than 2 return true
            {
                return true;
            }
            else if (str.Length < str1.Length) // if lenght of 1 is smaller than 2 return false
            {
                return false;
            }
            else
            {
                // iterate through to get numeric value at i if lengths are equal
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] > str1[i])
                    {
                        return true;
                    }
                    else if (str[i] == str1[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            // all else returns default value
            return false;
        }

        // Create IsLessThan() method
        public bool IsLessThan(HugeInteger hugeInt)
        {
            // if greater or equal, return false
            if (this.IsEquals(hugeInt) || this.IsGreaterThan(hugeInt))
            {
                return false;
            }

            // else return true
            return true;
        }

        // Create IsGreaterThanOrEquals() method
        public bool IsGreaterThanOrEquals(HugeInteger hugeInt)
        {
            // if equls or greater return true
            if (this.IsGreaterThan(hugeInt) || this.IsEquals(hugeInt))
            {
                return true;
            }

            // else return false
            return false;
        }

        // Create IsLessThanOrEquals() method
        public bool IsLessThanOrEquals(HugeInteger hugeInt)
        {
            // if equals or less than return true
            if (this.IsLessThan(hugeInt) || this.IsEquals(hugeInt))
            {
                return true;
            }

            // else return false
            return false;
        }


        // Addition method to add two HugeInts
        public HugeInteger Addition(HugeInteger hugeInt)
        {
            // Initiate two inputs as strings 
            String longStr1 = hugeInt.ToString();
            String longStr2 = this.ToString();

            // create necessary variables for the method
            String result = string.Empty; // empty string for storing results
            int carry = 0; // carry variable that has a default of 0

            // Ensure second string is larger
            if (longStr1.Length > longStr2.Length)
            {
                String tmp = longStr1;
                longStr1 = longStr2;
                longStr2 = tmp;
            }

            // Reverse both of the strings to prepare for addition + carry
            longStr1 = Reverse(longStr1);
            longStr2 = Reverse(longStr2);

            // iterate through the number
            for (int i = 0; i < longStr1.Length; i++)
            {
                // sum of current digits + carry if there is 
                int digitSum = ((int)(longStr1[i] - '0') + (int)(longStr2[i] - '0') + carry);
                result += (char)(digitSum % 10 + '0'); // add to result string (minus carry)

                carry = digitSum / 10; // calculate carry for the following iteration
            }

            // Add remaining digits 
            for (int i = longStr1.Length; i < longStr2.Length; i++)
            {
                // sum of remaining digits + carry if there is
                int digitSum = ((int)(longStr2[i] - '0') + carry);
                result += (char)(digitSum % 10 + '0');
                carry = digitSum / 10;
            }

            // Add remaining carry if there is one at the end of the calculations
            if (carry > 0)
            {
                result += (char)(carry + '0');
            }

            // reverse the result string back to its right order
            result = Reverse(result);

            // turn the result into a HugeInteger
            HugeInteger additionResult = new HugeInteger();
            additionResult.Input(result);

            // final return for the method
            return additionResult;
        }


        // Subtraction method to add two HugeInts
        public HugeInteger Subtraction(HugeInteger hugeInt)
        {
            // Initiate two inputs as strings 
            String longStr1 = hugeInt.ToString();
            String longStr2 = this.ToString();

            // ensure second string is smaller
            if (IsSmaller(longStr1, longStr2))
            {
                string t = longStr1;
                longStr1 = longStr2;
                longStr2 = t;
            }

            // Create the necessary variables for the method
            String result = string.Empty;
            int length1 = longStr1.Length, length2 = longStr2.Length;
            int diff = length1 - length2;
            int carry = 0;

            // iterate from the end to avoid reversing
            for (int i = length2 - 1; i >= 0; i--)
            {
                // current digit difference
                int digitDiff = (((int)longStr1[i + diff] - (int)'0') - ((int)longStr2[i] - (int)'0') - carry);
                if (digitDiff < 0)
                { // calculate carry and make negative value positive
                    digitDiff = digitDiff + 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                result += digitDiff.ToString();
            }

            // subtraction of rest of longer number - iterate from end to avoid reverse
            for (int i = length1 - length2 - 1; i >= 0; i--)
            {
                if (longStr1[i] == '0' && carry > 0)
                { // calculate remaining carry
                    result += "9";
                    continue;
                }
                int digitDiff = (((int)longStr1[i] - (int)'0') - carry); // calc digitDiff
                if (i > 0 || digitDiff > 0) // remove 0s from beginning
                {
                    result += digitDiff.ToString();
                } // reinitialize to 0
                carry = 0;
            }

            // reverse resultant string
            string output = Reverse(result);

            // convert to HugeInteger
            HugeInteger subtractionResult = new HugeInteger();
            subtractionResult.Input(output);

            return subtractionResult;
        }



        //Multiplication method to add two HugeInts
        public HugeInteger Multiplication(HugeInteger hugeInt)
        {
            // Initiate two inputs as strings 
            String longStr1 = hugeInt.ToString();
            String longStr2 = this.ToString();

            // Create the necessary variables for the method
            int length1 = longStr1.Length, length2 = longStr2.Length;
            int[] result = new int[length1 + length2];
            int index1 = 0;
            int index2;
            int i;

            // Calculate if one of the numbers are = 0 result is 0
            if (length1 == 0 || length2 == 0)
            { // create Huge Integer to return
                HugeInteger hugeIntZero = new HugeInteger();
                hugeIntZero.Input("0");
                return hugeIntZero;
            }

            // Go from right to left in num1
            for (i = length1 - 1; i >= 0; i--)
            {
                // more necessary variables for the loop
                int carry = 0;
                int n1 = longStr1[i] - '0';

                // shift position left after each digitproduct
                index2 = 0;

                // iterate from right to left in first number           
                for (int j = length2 - 1; j >= 0; j--)
                {
                    // current digit of second number
                    int n2 = longStr2[j] - '0';

                    // product of current digits
                    int product = n1 * n2 + result[index1 + index2] + carry;

                    // Carry for next itercharAtion
                    carry = product / 10;

                    // Store result
                    result[index1 + index2] = product % 10;

                    index2++;
                }

                // store carry
                if (carry > 0)
                {
                    result[index1 + index2] += carry;
                }

                index1++;
            }

            // ignore 0s 
            i = result.Length - 1;
            while (i >= 0 && result[i] == 0)
            {
                i--;
            }

            // if all are 0 return 0
            if (i == -1)
            {
                HugeInteger hugeIntZero = new HugeInteger();
                hugeIntZero.Input("0");
                return hugeIntZero;
            }

            // put it all into a result string
            String productResult = string.Empty;
            while (i >= 0)
            {
                productResult += (result[i--]);
            }

            // convert to HugeInteger
            HugeInteger multiplicationResult = new HugeInteger();
            multiplicationResult.Input(productResult);

            return multiplicationResult;
        }


        // Division method to add two HugeInts
        public HugeInteger Division(HugeInteger divisor)
        {
            // initiate Huge Integers 
            HugeInteger dividend = new HugeInteger();
            dividend.numbers = numbers;

            HugeInteger quotient = new HugeInteger();
            quotient.Input("0");

            HugeInteger addOne = new HugeInteger();
            addOne.Input("1");


            if (dividend.IsLessThan(divisor))
            { // if dividend > divisor return 0 as it cannot be divided
                return quotient;
            }

            while (dividend.IsGreaterThanOrEquals(divisor))
            { // remove 1xdivisor from dividend and add one to quotient while i can
                //Console.WriteLine(dividend.IsGreaterThanOrEquals(divisor));
                dividend = dividend.Subtraction(divisor);
                quotient = quotient.Addition(addOne);
            }

            return quotient;
        }


        // Remainder method to add two HugeInts
        public HugeInteger Remainder(HugeInteger divisor)
        {
            // initiate Huge Integers 
            HugeInteger dividend = new HugeInteger();
            dividend.numbers = numbers;

            if (dividend.IsLessThan(divisor))
            { // if dividend < divisor return dividend
                return dividend;
            }

            while (dividend.IsGreaterThanOrEquals(divisor))
            { // remove divisor and return whats left
                dividend = dividend.Subtraction(divisor);
            }

            // trim out the 0s from the beginning of the result
            string dividendString = dividend.ToString();
            dividend.Input(dividendString.TrimStart('0'));

            return dividend;
        }
    }
}

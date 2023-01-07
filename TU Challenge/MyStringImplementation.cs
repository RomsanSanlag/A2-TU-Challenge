using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string debut = "";
            string fin = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    debut += input[i];
                }
                else
                {
                    fin += input[i];
                }
            }
            string toReturn = debut += fin;
            return toReturn;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                char c = input[i];
                if ((c >= 'a') && (c <= 'z'))
                {
                    return false;
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (!IsNullEmptyOrWhiteSpace(a)) throw new ArgumentException();
            if (!IsNullEmptyOrWhiteSpace(b)) throw new ArgumentException();

            string toReturn = "";
            bool inverseString = true;
            int iteratorA = 0;
            int iteratorB = 0;

            do
            {
                if (iteratorA > a.Length - 1 && iteratorB > b.Length - 1) { return toReturn; }

                if (iteratorA > a.Length - 1)
                {
                    inverseString = false;
                }
                else if (iteratorB > b.Length - 1)
                {
                    inverseString = true;
                }

                if (inverseString)
                {
                    toReturn += a[iteratorA];
                    iteratorA++;
                }
                else
                {
                    toReturn += b[iteratorB];
                    iteratorB++;
                }

                inverseString = !inverseString;
            } while (toReturn.Length <= a.Length + b.Length);

            return toReturn;
        }

        public static string Reverse(string a)
        {
            string toReturn = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                toReturn += a[i];
            }
            return toReturn;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string toReturn = "";
            foreach(char a in input)
            {
                if (a == ' ')
                {
                    toReturn += a;
                }
                else
                {
                    char c = char.IsUpper(a) ? 'A' : 'a';
                    toReturn += (char)((((a + offset) - c) % 26) + c);
                }
                
            }
            return toReturn;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                int asciiNb = (int)a[i];
                if ((asciiNb >= 65 && asciiNb <= 90)||
                    (asciiNb >= 192 && asciiNb <= 214)||
                    (asciiNb >= 216 && asciiNb <= 222))
                {
                    asciiNb += 32;
                }
                result += (char)asciiNb;
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                a += input[i];
            }
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                b += input[i];
            }
            return MixString(a, b);
        }

        public static string Voyelles(string a)
        {
            string tmp = ToLowerCase(a);
            string voyelles = "aeiouy";
            string toReturn = "";
            foreach(char c in tmp)
            {
                foreach(char c2 in voyelles)
                {
                    if (c==c2)
                    {
                        bool isInString = false;
                        foreach (char c3 in toReturn)
                        {
                            if (c3 == c)
                            {
                                isInString = true;
                            }
                        }
                        if (!isInString)
                        {
                            toReturn += c;
                        }
                    }
                }
            }
            return toReturn;
        }
    }
}

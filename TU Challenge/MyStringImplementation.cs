using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            throw new NotImplementedException();
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
            string stringToReturn = "";
            int testLengthA = a.Length;
            int testLengthB = b.Length;
            int conditionFor = 0;

            if ((testLengthA > testLengthB) || testLengthA == testLengthB)
            {
                conditionFor = testLengthA;
            }
            else conditionFor = testLengthB;
            
            for(int i = 0; i < conditionFor; i++)
            {
                if (i <= testLengthB)
                {
                    char string1 = a[i];
                    stringToReturn += string1;
                    a.Remove(i);
                }
                    
                if (i <= testLengthB)
                {
                    char string2 = b[i];
                    stringToReturn += string2;
                    b.Remove(i);
                }

                //tester les strings pour voir si elles sont vides avant de refaire un tour
/*                if (IsNullEmptyOrWhiteSpace(a))
                {
                    stringToReturn += b;
                    break;
                }
                else if (IsNullEmptyOrWhiteSpace(b))
                {
                    stringToReturn += a;
                    break;
                }*/
                
            }
            return stringToReturn;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            string tmp = ToLowerCase(a);
            string voyelles = "aeiou";
            string toReturn = "";
            int lengthTmp = tmp.Length;
            int lengthVoyelles = voyelles.Length;
            for (int i = 0; i < lengthTmp; i++)
            {
                char c = tmp[i];
                for (int j = 0; i < lengthVoyelles; i++)
                {
                    if (c == voyelles[j])
                    {
                        toReturn += c;
                        break;
                    }
                }
            }
            return toReturn;
        }
    }
}

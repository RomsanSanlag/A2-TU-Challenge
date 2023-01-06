using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> NbPrimary = new List<int>();
            while (a != 0)
            {
                if (IsPrimary(a))
                {
                    NbPrimary.Add(a);
                }
                a--;
            }
            return NbPrimary;
        }

        public static bool IsDivisible(int a, int b)
        {
            int c = a % b;
            if (c == 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a<b)
            {
                return 1;
            }
            else if (a>b)
            {
                return -1;
            }
            else return 0;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            bool isInOrder = false;
            int TmpElement = list.ElementAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                int Elem = list.ElementAt(i);
                if (Elem >= TmpElement)
                {
                    isInOrder = true;
                }
                else return false;
            }
            return isInOrder;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0) throw new ArgumentException();
            if (age >= 150) throw new ArgumentException();
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPrimary(int a)
        {
            int i = 2;
            int repetition = 0;
            while (a % i !=0)
            {
                repetition++;
                i++;
            }
            if(repetition==(a-2))
            {
                return true;
            }
            else return false;
        }

        public static int Power(int a, int b)
        {
            if (b != 0)
            {
                int nbTemp = a;
                for (int i = 1; i < b; i++)
                {
                    nbTemp *= a;
                }
                return nbTemp;
            }
            else return 1;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            throw new NotImplementedException();
            //toSort.RemoveAt
            //toSort.Insert
            /*
            int TmpElement = toSort.ElementAt(0);
            int iterator = 1;
            bool isSort = false;
            while (isSort == false)
            {
                int Elem = toSort.ElementAt(iterator);
                if ((Elem == TmpElement) || (Elem > TmpElement))
                {
                    Elem = TmpElement;
                    iterator++;
                }
                else if (Elem < TmpElement)
                {
                    int ElemToAdd = Elem;
                    toSort.RemoveAt(iterator);
                    toSort.Insert((iterator - 1), ElemToAdd);
                    iterator++;
                }
                isSort = IsListInOrder(toSort);
            }
            return toSort;*/
        }
    }
}

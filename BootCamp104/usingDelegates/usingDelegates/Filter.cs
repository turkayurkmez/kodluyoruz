using System;
using System.Collections.Generic;
using System.Text;

namespace usingDelegates
{
    public static class Filter
    {

        //public delegate bool Criteria(int value);
       // public delegate void Show(int value);
        public static int[] FilterArray(int[] array, Func<int,bool> myCriteriaFunction, Action<int> showAction)
        {
            //array içindeki çift sayıları filtrelemek....
            List<int> result = new List<int>();
            foreach (var value in array)
            {
                if (myCriteriaFunction(value))
                {
                    result.Add(value);
                }
                showAction(value);
            }
            

            return result.ToArray();
        }
    }
}

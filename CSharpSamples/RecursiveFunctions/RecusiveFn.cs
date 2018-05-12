using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.RecursiveFunctions
{
    public static class RecusiveFn
    {
        public static List<List<T>> GetSubsets<T>(this List<T> data) where T : struct
        {
            try
            {
                if (data != null)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        int diff = data.Count - (i);
                        T head = data[i];
                        List<T> tempList = data.ToList<T>();
                        tempList.Remove(head);
                        for (int j = 0; j < tempList.Count; j++)
                        {

                        }
                    }
                    return new List<List<T>>();
                }
                else
                {
                    return new List<List<T>>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int BinaryASearch<T>(this List<T> data, T item) where T : struct
        {
            int index = -1;
            try
            {
                if (data != null)
                {
                    bool notFound = true;
                    int mixIndex = data.Count / 2;
                    while (notFound)
                    {
                        if (mixIndex < data.Count)
                        {
                            break;
                        }
                        if (Comparer<T>.Default.Compare(item, data[mixIndex]) == 0)
                        {
                            notFound = false;
                            index = mixIndex;
                        }
                        else if (Comparer<T>.Default.Compare(item, data[mixIndex]) <= 0 )
                        {
                            mixIndex = mixIndex / 2;
                        }
                        else if (Comparer<T>.Default.Compare(item, data[mixIndex + 1]) >= 0)
                        {
                            mixIndex = (data.Count + mixIndex) / 2;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return index;
        }

    }
}

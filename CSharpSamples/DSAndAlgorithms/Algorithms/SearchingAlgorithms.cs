using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Algorithms
{
    public static class SearchingAlgorithms
    {
        /// <summary>
        /// Binary search algorithm
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="data">Current list object</param>
        /// <param name="item">object to find</param>
        /// <returns>Index of the item in the list or -1 if not found</returns>
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
                        else if (Comparer<T>.Default.Compare(item, data[mixIndex]) <= 0)
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

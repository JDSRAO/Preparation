using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Algorithms
{
    /// <summary>
    /// Contains below soring algorithms
    /// Bubble sort, Merge Sort, Quick sort, Insertion Sort
    /// </summary>
    public static class SortingAlgorithms
    {
        public static void SimpleSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                T item1 = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    T item2 = list[j];
                    if (Compare(item1, item2) > 0)
                    {
                        list.Swap(i,j);
                    }
                }
            }
        }

        public static void BubbleSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null) && list.Any())
            {
                int itrs = 0;
                int n = list.Count;
                bool exchanged = true;
                int compares = list.Count - 1;
                while (exchanged && compares > 0)
                {
                    exchanged = false;
                    for (int i = 0; i < n; i++)
                    {
                        if ((i != n - 1) && Compare(list[i], list[i + 1]) > 0)
                        {
                            list.Swap(i, i + 1);
                            exchanged = true;
                        }
                        itrs++;
                    }
                    compares--;
                }

                Console.WriteLine(itrs);
            }
        }

        public static void BubbleSortOptimised<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null) && list.Any())
            {
                int itrs = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count - i - 1; j++)
                    {
                        itrs++;
                        if (Compare(list[j], list[j + 1]) > 0)
                        {
                            list.Swap(j, j + 1);
                        }
                    }
                }
                Console.WriteLine(itrs);
            }
        }



        public static void QuickSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null))
            {
                if (list.Any())
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = i; j < list.Count; j++)
                        {
                            T item2 = list[j];
                            if (Compare(item1, item2) > 0)
                            {
                                int index = list.FindIndex(x => x.Equals(item1));
                                list.Swap(index, j);
                            }
                        }
                    }
                }
            }
        }

        public static void MergeSort<T>(this List<T> list) where T : IComparable<T>
        {
            if (!ReferenceEquals(list, null) && list.Any())
            {
                list.MergeNSort(0, list.Count - 1);
            }
        }

        public static void InsertionSort1<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list,null))
            {
                if (list.Any())
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = i; j > 0; j--)
                        {
                            T item2 = list[j];
                            if (Compare(item1, item2) > 0)
                            {
                                //list.Slide(item2, j, i);
                            }
                        }
                    }
                }
            }
        }

        public static void InsertionSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null))
            {
                if (list.Any())
                {
                    var localList = list.ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = 0; j <= i; j++)
                        {
                            T item2 = localList[j];
                            if (Compare(item1, item2) > 0)
                            {
                                localList.Slide(item2, j, i);
                                break;
                            }
                        }
                    }
                    list = localList.ToList();
                }
            }
        }

        public static void InsertionSortBookAlgo<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list,null) && list.Any())
            {
                int unSorted = 1;
                while (unSorted < list.Count)
                {
                    T hold = list[unSorted];
                    int i = unSorted - 1;
                    T item = list[i];
                    while (i >=0 && (Compare(hold, item) < 0))
                    {
                        list[i + 1] = list[i];
                        i = i - 1;
                    }
                    list[i + 1] = hold;
                    unSorted = unSorted + 1;
                }
            }
        }

        public static void ShellSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (ReferenceEquals(list, null) && list.Any())
            {
                int increment = list.Count / 2;
                while (increment != 0)
                {
                    int current = increment;
                    while (current < list.Count)
                    {
                        T hold = list[current];
                        int i = current - increment;
                        while (i >= 0 && Compare(hold, list[i]) < 0)
                        {
                            list[i + increment] = list[i];
                            i -= increment;
                        }
                        list[i + increment] = hold;
                        current = current + 1;
                    }
                    increment /= 2;
                }
            }
        }

        public static void Slide<T>(this List<T> list, T item, int min, int max) where T : IComparable<T>
        {
            if (min < max && (list.Count > max))
            {
                //var subList = list.GetSubList(min, max);
                //for (int i = min + 1; i <= max; i++)
                //{
                //    int j = i - min - 1;
                //    list[i] = subList[j];
                //}
                //list[min] = item;
                for (int i = min; i < max; i++)
                {
                    list[i + 1] = list[i];
                }
                list[min] = item;
            }
        }

        public static List<T> GetSubList<T>(this List<T> list, int min, int max) where T : IComparable<T>
        {
            if (ReferenceEquals(list, null))
            {
                return null;
            }
            if (list.Count == 0)
            {
                return new List<T>();
            }
            if (list.Count < max)
            {
                throw new InvalidOperationException();
            }

            List<T> subList = new List<T>();

            for (int i = min; i <= max; i++)
            {
                subList.Add(list[i]);
            }

            return subList;
        }

        # region Helper Methods

        private static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private static int Compare<T>(T item1, T item2) //where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }

        private static void Swap<T>(this List<T> list, int min, int max)
        {
            if (!ReferenceEquals(list, null) && (max < list.Count))
            {
                T temp = list[min];
                list[min] = list[max];
                list[max] = temp;
            }
        }

        private static void MergeNSort<TSource>(this List<TSource> list, int min, int max)
        {
            if (min < max)
            {
                int mid = (min + max) / 2;
                list.MergeNSort(min, mid);
                list.MergeNSort(mid + 1, max);
                Merge(list, min, mid, max);
            }
        }

        private static void Merge<T>(this List<T> list, int min, int mid, int max)
        {
            List<T> left = list.GetRange(min, mid - min + 1);
            List<T> right = list.GetRange(mid + 1, max - mid);

            int j = 0, i = 0, k = mid;
            //while (i < left.Count && j < right.Count)
            //{
            //    if (Compare(left[i], right[j]) < 0)
            //    {
            //        list[k] = left[i];
            //        i++;
            //    }
            //    else
            //    {
            //        list[k] = right[j];
            //        j++;
            //    }

            //    k++;
            //}

            for (i = 0, j = 0; i < left.Count && j < right.Count; i++, j++)
            {
                if (Compare(left[i], right[j]) < 0)
                {
                    list[k] = left[i];
                }
                else
                {
                    list[k] = right[j];
                }

                k++;
            }

            while (i < left.Count)
            {
                list[k] = left[i];
                k++;
                i++;
            }

            while (j < right.Count)
            {
                list[k] = right[j];
                k++;
                j++;
            }

        }

        # endregion 
    }
}

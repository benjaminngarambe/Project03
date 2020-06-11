using System;

namespace Project03
{
    internal class ArrayGeneratorClass
    {
        public static int[] Generate(int size)
        {
            var rnd = new Random();
            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(int.MinValue, int.MaxValue);
            }

            return array;
        }

        // Generating values that are going to be from range 0 to Range 2000 as Maximum
        public static int[] GenerateSpecific(int max)
        {
            var rnd = new Random();
            var array = new int[2000];

            for (int i = 0; i < 2000; i++)
            {
                array[i] = rnd.Next(max + 1);
            }

            return array;
        }

        public static int[] GenerateSortedArray(int size)
        {
            var array = Generate(size);
            Array.Sort(array);

            return array;
        }

        //Generating specific sorted array
        public static int[] GenerateSortedSpecific(int max)
        {
            var array = GenerateSpecific(max);
            Array.Sort(array);

            return array;
        }

        //Generating Reversed sorted array
        public static int[] GenerateReversed(int size)
        {
            var array = GenerateSortedArray(size);
            Array.Reverse(array);

            return array;
        }

        //Generating Reversed sorted array
        public static int[] GenerateReversedSpecific(int max)
        {
            var array = GenerateSortedSpecific(max);
            Array.Reverse(array);

            return array;
        }

        //Generating constant array
        public static int[] GenerateConstant(int size)
        {
            var rnd = new Random();
            var array = new int[size];

            var value = rnd.Next(int.MinValue, int.MaxValue);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        //Generating constant specific array
        public static int[] GenerateConstantSpecific(int max)
        {
            var rnd = new Random();
            var array = new int[2000];

            var value = rnd.Next(max + 1);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        public static int[] GenerateShapedArray(int size)
        {
            int mark = 1;
            int first = 1;
            int last = size - 1;

            var array = GenerateSortedArray(size);
            var ShortTimeArray = new int[size];

            array.CopyTo(ShortTimeArray, 0);//copy all elements of the one dimensional array

            while (first <= last)
            {
                if (mark % 2 == 1)
                {
                    array[last--] = ShortTimeArray[mark++];
                }
                else
                {
                    array[first++] = ShortTimeArray[mark++];
                }
            }

            return array;
        }

        public static int[] GenerateAShapedSpecific(int max)
        {
            int index = 1;
            int first = 1; // mark 0 is always at 0 so we start from 1;
            int last = 2000 - 1;

            var array = GenerateSortedSpecific(max);
            var TemporaryArray = new int[2000];

            array.CopyTo(TemporaryArray, 0);

            while (first <= last)
            {
                if (index % 2 == 1)
                {
                    array[last--] = TemporaryArray[index++];
                }
                else
                {
                    array[first++] = TemporaryArray[index++];
                }
            }

            return array;
        }

        public static int[] GenerateVShaped(int size)
        {
            // in order for us to know the middle
            int index = (size - 1) / 2;
            int TemporaryArraySign = 0;

            var array = GenerateSortedArray(size);
            var shortTimArray = new int[size];

            array.CopyTo(shortTimArray, 0);

            for (int i = 1; TemporaryArraySign != size; i++)
            {
                if (i % 2 == 1)
                {
                    array[index] = shortTimArray[TemporaryArraySign++];
                    index += i;
                }
                else
                {
                    array[index] = shortTimArray[TemporaryArraySign++];
                    index -= i;
                }
            }

            return array;
        }

        public static int[] GenerateVShapedSpecific(int max)
        {
            int index = (2000 - 1) / 2; // center
            int tempindex = 0;

            var array = GenerateSortedSpecific(max);
            var ShortTimArray = new int[2000];

            array.CopyTo(ShortTimArray, 0);

            for (int i = 1; tempindex != 2000; i++)
            {
                if (i % 2 == 1)
                {
                    array[index] = ShortTimArray[tempindex++];
                    index = i + index;
                }
                else
                {
                    array[index] = ShortTimArray[tempindex++];
                    index = i - index;
                }
            }

            return array;
        }

        public static void SelectionSort(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int index = i;

                for (int j = i + 1; j < length; j++) // from unsorted to the end
                {
                    if (array[j] < array[index])
                    {
                        index = j;
                    }
                }

                int temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }

        public static void BubbleSort(int[] array)
        {
            int tempvalue;
            bool swapped;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempvalue = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempvalue;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }
            }
        }

        public static void HeapSort(int[] array)
        {
            int length = array.Length;

            for (int i = length / 2 - 1; i >= 0; i--)
            {
                MakeHeapSort(array, length, i);
            }

            for (int i = length - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                MakeHeapSort(array, i, 0);
            }
        }

        private static void MakeHeapSort(int[] array, int length, int i)
        {
            int Biggest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int temp;

            if (left < length && array[left] > array[Biggest])
            {
                Biggest = left;
            }

            if (right < length && array[right] > array[Biggest])
            {
                Biggest = right;
            }

            if (Biggest != i)
            {
                temp = array[i];
                array[i] = array[Biggest];
                array[Biggest] = temp;

                MakeHeapSort(array, length, Biggest);
            }
        }

        public static void CountingSort(int[] array, int max)
        {
            var value = new int[max + 1];

            for (int i = 0; i < array.Length; i++)
            {
                ++value[array[i]];
            }

            int index = 0;

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j < value[i]; j++)
                {
                    array[index++] = i;
                }
            }
        }
    }
}
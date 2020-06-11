//program: Sorting algorithms
//Programer: Ngarambe Benjamin
//Year: 2020
using System;
using System.Diagnostics;

namespace Project03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int size;

            char userInput;
            int[] randomArray, ascendingArray, reversedArray, vShapedArray, aShapedArray;
            bool AnInt;
            var stopwatch = new Stopwatch();

            do
            {
                Console.Clear();
                Console.WriteLine("the array size is equal to 2000");
                Console.WriteLine("Type '1' for Bubble Sort; '2' for Selection Sort;'3' for Heap Sort;'4' for Counting sort");
                userInput = Console.ReadKey().KeyChar;
            } while (!(userInput == '1' || userInput == '2' || userInput == '3' || userInput == '4'));
            Console.Clear();

            switch (userInput)
            {
                case '1':
                case '2':
                case '3':
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("What size of array should be?");
                        AnInt = int.TryParse(Console.ReadLine(), out size);
                    } while (!AnInt || !(size > 0) || !(size < int.MaxValue));
                    Console.Clear();

                    randomArray = ArrayGeneratorClass.Generate(size);
                    ascendingArray = ArrayGeneratorClass.GenerateSortedArray(size);
                    reversedArray = ArrayGeneratorClass.GenerateReversed(size);
                    vShapedArray = ArrayGeneratorClass.GenerateVShaped(size);
                    aShapedArray = ArrayGeneratorClass.GenerateShapedArray(size);

                    switch (userInput)
                    {
                        case '1':
                            stopwatch.Start();
                            ArrayGeneratorClass.BubbleSort(randomArray);
                            stopwatch.Stop();
                            Console.WriteLine($"randomArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.BubbleSort(ascendingArray);
                            stopwatch.Stop();
                            Console.WriteLine($"ascendingArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.BubbleSort(reversedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"reversedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.BubbleSort(vShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"vShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.BubbleSort(aShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"aShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            break;

                        case '2':
                            stopwatch.Start();
                            ArrayGeneratorClass.SelectionSort(randomArray);
                            stopwatch.Stop();
                            Console.WriteLine($"randomArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.SelectionSort(ascendingArray);
                            stopwatch.Stop();
                            Console.WriteLine($"ascendingArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.SelectionSort(reversedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"reversedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.SelectionSort(vShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"vShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.SelectionSort(aShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"aShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            break;

                        case '3':
                            stopwatch.Start();
                            ArrayGeneratorClass.HeapSort(randomArray);
                            stopwatch.Stop();
                            Console.WriteLine($"randomArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.HeapSort(ascendingArray);
                            stopwatch.Stop();
                            Console.WriteLine($"ascendingArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.HeapSort(reversedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"reversedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.HeapSort(vShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"vShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            stopwatch.Start();
                            ArrayGeneratorClass.HeapSort(aShapedArray);
                            stopwatch.Stop();
                            Console.WriteLine($"aShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                            stopwatch.Reset();

                            break;
                    }
                    break;

                case '4':
                    int Maximum;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("What maximum int value should be?(values: from 0 to Maximum)");
                        AnInt = int.TryParse(Console.ReadLine(), out Maximum);
                    } while (!AnInt || !(Maximum > 0) || !(Maximum < int.MaxValue - 1));
                    Console.Clear();

                    randomArray = ArrayGeneratorClass.GenerateSpecific(Maximum);
                    ascendingArray = ArrayGeneratorClass.GenerateSortedSpecific(Maximum);
                    reversedArray = ArrayGeneratorClass.GenerateReversedSpecific(Maximum);
                    vShapedArray = ArrayGeneratorClass.GenerateVShapedSpecific(Maximum);
                    aShapedArray = ArrayGeneratorClass.GenerateAShapedSpecific(Maximum);

                    stopwatch.Start();
                    ArrayGeneratorClass.CountingSort(randomArray, Maximum);
                    stopwatch.Stop();
                    Console.WriteLine($"randomArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                    stopwatch.Reset();

                    stopwatch.Start();
                    ArrayGeneratorClass.CountingSort(ascendingArray, Maximum);
                    stopwatch.Stop();
                    Console.WriteLine($"ascendingArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                    stopwatch.Reset();

                    stopwatch.Start();
                    ArrayGeneratorClass.CountingSort(reversedArray, Maximum);
                    stopwatch.Stop();
                    Console.WriteLine($"reversedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                    stopwatch.Reset();

                    stopwatch.Start();
                    ArrayGeneratorClass.CountingSort(aShapedArray, Maximum);
                    stopwatch.Stop();
                    Console.WriteLine($"aShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                    stopwatch.Reset();

                    stopwatch.Start();
                    ArrayGeneratorClass.CountingSort(vShapedArray, Maximum);
                    stopwatch.Stop();
                    Console.WriteLine($"vShapedArray:{stopwatch.Elapsed.TotalMilliseconds}ms");
                    stopwatch.Reset();

                    break;
            }

            Console.ReadLine();
        }
    }
}
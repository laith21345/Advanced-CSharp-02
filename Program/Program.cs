using System.Collections;
using System.Globalization;
using System.Threading.Channels;


namespace Program
{
    internal class Program
    {
        // بسم الله الرحمن الرحيم
        // Advanced C# 02
        // Assignment 02

        public static T[] ReadArrayFromConsole<T>(int size) where T : IParsable<T>
        {
            T[] array = new T[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = T.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            return array;
        }

        static void Main(string[] args)
        {

            #region Q1
            //1. Given an array consists of numbers with size N and number of queries,
            //   in each query you will be given an integer X, and you should print how many numbers
            //   in array that is greater than  X.
            //
            //Ex:
            //Input
            //3 3                //Size of array , number of queries
            //11 5 3             //Array 
            //1                  //Query1
            //5                  //Query2
            //13                 //Query3
            //Output
            //3                  //11,5,3
            //1                  //11
            //0 

            //int count;
            //int query;

            //int size;
            //int[] numbers;

            //int numberOfQueries;
            //Queue<int> queue = new Queue<int>();

            //Console.Write("enter the array size :");
            //size = int.Parse(Console.ReadLine());
            //numbers = new int[size];

            //Console.Write("enter the number of queries :");
            //numberOfQueries = int.Parse(Console.ReadLine());


            //Console.WriteLine("enter the numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numberOfQueries; i++)
            //{
            //    Console.Write($"enter the {i+1} Query :");
            //    query = int.Parse(Console.ReadLine());
            //    queue.Enqueue(query);
            //}

            //for (int i = 0; i <= queue.Count; i++)
            //{
            //    count = 0;
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[j] > queue.Peek()) count++;
            //    }
            //    Console.WriteLine(count);
            //    queue.Dequeue();
            //}

            #endregion

            #region Q2
            //2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //Ex:
            //Input:
            //5
            //1 3 2 3 1
            //Output:
            //YES 

            //bool isPalindrome(int[]? source)
            //{
            //    if (source is null)
            //        return false;

            //    for (
            //        int start = 0, end = source.Length - 1;
            //        start < end;
            //        start++, end--
            //        )
            //    {
            //        if (source[start] != source[end])
            //            return false;
            //    }

            //    return true;
            //}


            //int size = int.Parse(Console.ReadLine());

            //int[] array = ReadArrayFromConsole<int>(size);

            //if(isPalindrome(array))
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Q3
            //3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //void ReverseQueue<T>(Queue<T> source)
            //{
            //    int size = source.Count;
            //    Stack<T> stack = new Stack<T>(size);

            //    for (int i = 0; i < size; i++)
            //    {
            //        stack.Push(source.Dequeue());
            //    }

            //    for (int i = 0; i < size; i++)
            //    {
            //        source.Enqueue(stack.Pop());
            //    }

            //}

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3 });
            //ReverseQueue<int>(queue);

            //while(queue.Count != 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            #endregion

            #region Q4
            //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //Ex:
            //Input:
            //[()]{}
            //Output:
            //Balanced

            //bool isValidParentheses(string? str)
            //{
            //    if (str == null) return false;

            //    int length = str.Length;
            //    Stack<char> stack = new Stack<char>(length);

            //    for (int i = 0; i < length; i++)
            //    {
            //        switch (str[i])
            //        {
            //            case '{':
            //            case '(':
            //            case '[':
            //            case '<':
            //                stack.Push(str[i]);
            //                break;

            //            case '}':
            //            case ')':
            //            case ']':
            //            case '>':
            //                if (0 == stack.Count)
            //                    return false;
            //                else
            //                {
            //                    switch (str[i])
            //                    {
            //                        case '}':
            //                            if (stack.Pop() != '{')
            //                                return false;
            //                            break;
            //                        case ')':
            //                            if (stack.Pop() != '(')
            //                                return false;
            //                            break;
            //                        case ']':
            //                            if (stack.Pop() != '[')
            //                                return false;
            //                            break;
            //                        case '>':
            //                            if (stack.Pop() != '<')
            //                                return false;
            //                            break;
            //                    }
            //                }
            //                break;

            //            default: return false;

            //        }
            //    }

            //    return true;
            //}

            //string str1 = "[()]{}";
            //string str2 = "{([<>])}";
            //Console.WriteLine($"str1 :{isValidParentheses(str1)}");
            //Console.WriteLine($"str2 :{isValidParentheses(str2)}");

            #endregion

            #region Q5
            //5. Given an array, implement a function to remove duplicate elements from an array.

            //void itemAtIndexGoToIndex<T>(T[] array, int index, int toIndex)
            //{
            //    if (array is null || index < 0 || toIndex < 0 || toIndex >= array.Length)
            //        return;

            //    for (int i = index; i <= toIndex - 1; i++)
            //    {
            //        array[i] = array[i + 1];
            //    }
            //}

            //void removeDuplicatesFromArrayV01<T>(ref T[]? array) where T : IComparable<T>
            //{
            //    if (array is null || array.Length == 0) return;

            //    int capacity = array.Length;

            //    for (int i = 0; i < capacity - 1; i++) //-1 because the last element will compare with all
            //    {
            //        for (int j = i + 1; j < capacity;)
            //        {
            //            if (array[i].CompareTo(array[j]) == 0)
            //            {
            //                itemAtIndexGoToIndex(array, j, capacity - 1);
            //                capacity--;
            //            }
            //            else
            //                j++;// because if there    [t]5 [t+1]5 [t+2]5
            //                    //after delete second  [t]5 [t+1]5 and the iterator value will = t+1 so t+1 will not deleted
            //        }
            //    }

            //    T[] temp = new T[capacity];
            //    for (int i = 0; i < capacity; i++)
            //    {
            //        temp[i] = array[i];
            //    }

            //    array = temp;
            //    return;
            //}

            //// not completed :)
            ////void removeDuplicatesFromArrayV02<T>(T[]? array) where T : IComparable<T>

            //int[] arr = { 1, 2, 1, 5, 5, 5, 5, 3, 4, 1 };
            //removeDuplicatesFromArrayV01(ref arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            #endregion

            #region Q6
            //6. Given an array list , implement a function to remove all odd numbers from it.

            //void removeOddNumbersFromArrayList(ref ArrayList? arrayList)
            //{
            //    if (arrayList == null || arrayList.Count == 0)
            //        return;

            //    for (int i = 0; i < arrayList.Count; i++)
            //    {
            //        if (arrayList[i] is int number)
            //        {
            //            if (number % 2 == 1)
            //            {
            //                arrayList.RemoveAt(i);
            //            }
            //        }
            //    }
            //}

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //removeOddNumbersFromArrayList(ref arrayList!);

            //for (int i = 0; i < arrayList.Count; i++)
            //    Console.Write($"{arrayList[i]} ");
            #endregion

            #region Q7
            //7. Implement a queue that can hold different data types. 
            //And insert the following data:

            //Q7.Queue queue = new Q7.Queue(5);
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            #endregion

            #region Q8
            //8. Create a function that pushes a series of integers onto a stack.
            //   Then, search for a target integer in the stack.
            //   If the target is found, print a message indicating that the target was found
            //   how many elements were checked before finding the target
            //   (“Target was found successfully and the count = 5”).
            //   If the target is not found, print a message indicating that the target was not found
            //      :(“Target was not found”).
            //Note : take the target as input from the user

            //void integersOntoAStack(params int[] numbers)
            //{
            //    int count = 0;
            //    int target;
            //    Stack<int> stack = new Stack<int>(numbers.Length);

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        stack.Push(numbers[i]);
            //    }

            //    Console.Write("enter the target :");
            //    target = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < stack.Count; i++)
            //    {
            //        if (stack.Pop() == target)
            //        {
            //            Console.WriteLine($"Target was found successfully and the count = {count}");
            //            return;
            //        }
            //        else
            //            count++;
            //    }
            //    Console.WriteLine("Target was not found");
            //}

            //integersOntoAStack(1,2,3,4);

            #endregion

            #region Q9
            //9. Given two arrays, find their intersection.
            //   Each element in the result should appear as many times as it shows in both arrays.
            //Ex : 
            //Input :
            //5 , 3
            //[1,2,3,4,4] , [10,4,4]
            //Output : 
            //[4,4]

            //List<int> list01 = new List<int>([1, 2, 3, 4, 4]);
            //List<int> list02 = new List<int>([10, 4, 4]);

            //Stack<int> stack = new Stack<int>();

            //int value;
            //for (int i = 0; i < list02.Count;)
            //{
            //    value = list02[i];
            //    int atIndexInList01 = list01.IndexOf(value);
            //    if (atIndexInList01 >= 0)
            //    {
            //        stack.Push(value);
            //        list02.RemoveAt(i);
            //        list01.RemoveAt(atIndexInList01);
            //    }
            //    else
            //        i++;
            //}
            //while (stack.Count > 0)
            //{
            //    Console.Write($"{stack.Pop()} ");
            //}
            #endregion

            #region Q10
            //10. Given an ArrayList of integers and a target sum,
            //    find if there is a contiguous sub list that sums up to the target.
            //Ex : 
            //Input : 
            //[1, 2, 3, 7, 5]
            //12
            //Output : 
            //[2, 3, 7]

            //void upToTheTarget(ArrayList arrayList, int requiredSum, out int startIndex, out int endIndex)
            //{
            //    int sum = 0;
            //    startIndex = endIndex = 0;

            //    while (endIndex < arrayList.Count)
            //    {
            //        int value = (int)arrayList[endIndex]!;

            //        if (value >= requiredSum)
            //        {
            //            startIndex = ++endIndex;
            //            sum = 0;
            //        }
            //        else
            //        {

            //            sum += value;
            //            if (sum == requiredSum)
            //                return;
            //            else if (sum > requiredSum)
            //            {
            //                while (startIndex < endIndex)
            //                {
            //                    sum -= (int)arrayList[startIndex]!;
            //                    startIndex++;

            //                    if (sum == requiredSum)
            //                        return;
            //                }

            //                startIndex = ++endIndex;
            //                sum = 0;

            //            }
            //            else
            //            {
            //                endIndex++;
            //            }
            //        }

            //    }
            //}

            //int startIndex, endIndex, k;
            //ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 7, 5 });

            //k = int.Parse(Console.ReadLine());
            //upToTheTarget(arrayList, k, out startIndex, out endIndex);

            //if (endIndex < arrayList.Count)
            //    for (int i = startIndex; i <= endIndex; i++)
            //    {
            //        Console.Write($"{(int)arrayList[i]!} ");
            //    }

            #endregion

            #region Q11
            //11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            //Ex : 
            //Input : 
            //
            //[1 , 2 , 3 , 4 ,5] => queue :5,4,3,2,1 
            //K = 3
            //Output :
            //[3 , 2 , 1 , 4 ,5] => queue :5,4,1,2,3

            //void reverseFirstKElementsOfAQueue<T>(Queue<T> sourceQ, uint k)
            //{
            //    if (k > sourceQ.Count) return;

            //    Stack<T> stack = new Stack<T>(sourceQ.Count);
            //    Queue<T> tempQueue = new Queue<T>();

            //    while (k > 0)
            //    {
            //        stack.Push(sourceQ.Dequeue());
            //        k--;
            //    }

            //    while (sourceQ.Count > 0)
            //        tempQueue.Enqueue(sourceQ.Dequeue());

            //    while (stack.Count > 0)
            //        sourceQ.Enqueue(stack.Pop());

            //    while (tempQueue.Count > 0)
            //        sourceQ.Enqueue(tempQueue.Dequeue());

            //}                                
            //Queue<int> queue = new Queue<int>([1, 2, 3, 4, 5]);

            //reverseFirstKElementsOfAQueue(queue, 3);

            //while (queue.Count > 0)
            //    Console.Write($"{queue.Dequeue()} ");
            #endregion

        }
    }
}

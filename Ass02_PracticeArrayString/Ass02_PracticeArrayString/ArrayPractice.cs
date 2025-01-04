namespace Ass02_PracticeArrayString;

public class ArrayPractice
{
    public void CopyArray()
    {
        //populate the array: 
        int [] arr = new int [10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i*2;
        }
        //copy array
        int[] copyArr = new int[arr.Length];
        arr.CopyTo(copyArr, 0);
        for (int i = 0; i < copyArr.Length; i++)
        {
            copyArr[i] = arr[i];
        }
        Console.WriteLine("Original array: "+string.Join(",",arr));
        Console.WriteLine("Copied array: "+string.Join(",",copyArr));

    }

    public void ManageList()
    {
        var list = new List<string>();
        while (true)
        {
            Console.WriteLine("\n current list: "+string.Join(",",list));
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

            string input = Console.ReadLine();
            

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }
            else {
                if (input.ToLower().Equals("exit"))
                {
                    break;
                }
                if (input.StartsWith("+") && input.Length >2)
                {
                    list.Add(input.Substring(2));
                } else if (input.StartsWith("-") && input.Length > 2)
                {
                    list.Remove(input[2..]);
                } else if (input.Substring(0, 2).Equals("--"))
                {
                    list.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Command!");
                }
                
            }
        }

    }
    
    public  int[] FindPrimesInRange(int startNum, int endNum, string method)
    {
        //Method 1 : 
        var list = new List<int>();
        if (method == "array")
        {
            int[] arr = new int[endNum -startNum+ 1];
            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                if (i < 2) continue;
                bool isPrime = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    } 
                }

                if (isPrime)
                {
                    arr[count++] = i;
                }
            }
            int [] result = new int[count];
            Array.Copy(arr, result,count);
            return result; 
        } else if (method == "list") //method 2:
        {
            
            for (int n = startNum; n < endNum; n++)
            {
                bool isPrime = true;
                if(n < 2) continue;
                for (int k = 2; k < n; k++)
                {
                    if (n % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    list.Add(n);
                }
            }
            
        }
        return list.ToArray();
    }

    public void RotateArray(string method)
    {
        Console.WriteLine("Enter an array: ");
        int [] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("Enter number of rotations: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int n = numbers.Length;
        int [] sum  = new int[n];
        if (method == "loop")
        {
            
            for (int r = 0; r < k; r++)
            {
                int last = numbers[n-1];
                for (int i = n - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                }
                numbers[0] = last;
                for (int i = 0; i < n; i++)
                {
                    sum[i] += numbers[i];
                }
            }
            Console.WriteLine("Sum is: "+string.Join(" ", sum));
        } else if (method == "queue")
        {
            //left rotation
            Queue<int> q  = new Queue<int>(numbers);
            for (int i = 0; i < k; i++)
            {
                
                q.Enqueue(q.Dequeue());
                var rotated = q.ToArray();
                for (int j = 0; j < n; j++)
                {
                    sum[j] += rotated[j];
                }
            }
            Console.WriteLine("Sum is: "+string.Join(" ", sum));
        }

    }

    public void LongestSequence()
    {
        Console.WriteLine("Enter sequence: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int currentStart = 0;
        int currentLength = 1;
        int maxStart = 0;
        int maxLength = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i-1])
                currentLength++;
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStart = currentStart;
                }
                currentStart = i;
                currentLength = 1;
            }
        }

        // Check last sequence
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStart = currentStart;
        }

        // Print longest sequence
        for (int i = 0; i < maxLength; i++)
            Console.Write(arr[maxStart + i] + " ");
    }

    public void MostFrequentNumber(int [] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }
            dict[num]++;
        }

        int maxFreq = dict.Values.Max();
        int result = dict.First(x => x.Value == maxFreq).Key;
        Console.WriteLine(result);
    }
    
    
    
}


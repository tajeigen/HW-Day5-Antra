namespace hw_day5;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Hacker Name!");
        
        Console.WriteLine("What s your faborite Color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your name is : {color}");
        
        Console.WriteLine("What s your astrological sign? ");
        string sign = Console.ReadLine();
        Console.WriteLine($"Your sign is : {sign}");
        
        Console.WriteLine("What's your street address number? ");
        int nums =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your number is : {nums}");
        
        //hacker name is: 
        string hackerName = color + sign + Convert.ToString(nums);
        Console.WriteLine($"Your hacker name is : {hackerName}");
    }
}
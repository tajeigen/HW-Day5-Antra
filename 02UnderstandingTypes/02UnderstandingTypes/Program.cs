namespace _02UnderstandingTypes;

class Program
{
     static void compositeLearning()
    {
        Console.WriteLine("\nComposite Formatting\n");
        string printPrimes = string.Format("First 4 Primes Number are: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
        Console.WriteLine(printPrimes);
        
        
        string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
            "Ebenezer", "Francine", "George" };
        decimal[] hours = { 40, 6.667m, 40.39m, 82,
            40.333m, 80, 16.75m };

        Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");

        for (int counter = 0; counter < names.Length; counter++)
            Console.WriteLine("{0,-20} {1,5:N1}", names[counter], hours[counter]);


    }

    static void CenturyConversion()
    {
        // 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
        //        minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
        //    type for every data conversion. Beware of overflows!
        try
        {
            checked
            {
                Console.WriteLine("Enter the number of centuries:");
                int century = Convert.ToInt32(Console.ReadLine());
                int years = century * 100; 
                long days = (long)(years * 365.2425);
                long hours = days * 24;
                long minutes = hours * 60;
                long seconds = minutes * 60;
                long milliseconds = seconds * 1000;
                decimal microseconds = milliseconds * 1000;
                decimal nanoseconds = microseconds * 1000;
                
                Console.Write($"{century} Centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = ");
                Console.WriteLine($"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
           
        }
        catch (OverflowException)
        {
            Console.WriteLine("Calculation resulted in an overflow.");
            throw;
        }
      
    }

    public void PrintTypes()
    {
        Console.WriteLine("Understanding Types C#");
        Console.WriteLine("--------------------------\n");
        Console.WriteLine($"Number of bytes for sbyte: {sizeof(sbyte)} \nRange is from {sbyte.MinValue} to {sbyte.MaxValue}\n");
        Console.WriteLine($"Number of bytes for byte: {sizeof(byte)} \nRange is from {byte.MinValue} to {byte.MaxValue}\n");
        Console.WriteLine($"Number of bytes for short: {sizeof(short)} \nRange is from {short.MinValue} to {short.MaxValue}\n");
        Console.WriteLine($"Number of bytes for ushort: {sizeof(ushort)} \nRange is from {ushort.MinValue} to {ushort.MaxValue}\n");
        Console.WriteLine($"Number of bytes for int: {sizeof(int)} \nRange is from {int.MinValue} to {int.MaxValue}\n");
        Console.WriteLine($"Number of bytes for uint: {sizeof(uint)} \nRange is from {uint.MinValue} to {uint.MaxValue}\n");
        Console.WriteLine($"Number of bytes for long: {sizeof(long)} \nRange is from {long.MinValue} to {long.MaxValue}\n");
        Console.WriteLine($"Number of bytes for ulong: {sizeof(ulong)} \nRange is from {ulong.MinValue} to {ulong.MaxValue}\n");
        Console.WriteLine($"Number of bytes for float: {sizeof(float)} \nRange is from {float.MinValue} to {float.MaxValue}\n");
        Console.WriteLine($"Number of bytes for double: {sizeof(double)} \nRange is from {double.MinValue} to {double.MaxValue}\n");
        Console.WriteLine($"Number of bytes for decimal: {sizeof(decimal)} \nRange is from {decimal.MinValue} to {decimal.MaxValue}\n");


    }
    static void Main(string[] args)
    {
        // PrintTypes();
        // compositeLearning();
        // CenturyConversion();


    }
    

}

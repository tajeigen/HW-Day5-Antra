namespace Ass02_PracticeArrayString;

class Program
{
    
    static void Main(string[] args)
    {
        
        // ArrayPractice arrPractice = new ArrayPractice();
        // arrPractice.CopyArray();
        // arrPractice.ManageList();
        
        // int [] arr = arrPractice.FindPrimesInRange(1, 100,"array");
        // Console.WriteLine("Arr is:\n"+string.Join(" ", arr));
        // arrPractice.RotateArray("loop");
        // arrPractice.LongestSequence();
        
        // int[] arr = {4,1 ,1 ,4 ,2 ,3 ,4 ,4 ,1 ,2 ,4 ,9 ,3};
        // int[] arr1 = {7,7,7,0,2,2,2,0,10,10,10};
        // arrPractice.MostFrequentNumber(arr1);
        
        //string : 
        StringPractice strPractice = new StringPractice();
        
        // strPractice.ReverseString("reverseString");

        // string str = "C# is not C++, and PHP is not Delphi!";
        // strPractice.ReversePunctuatedSentence(str);
        
        // strPractice.ParseUrl("www.apple.com");
        string str = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
        strPractice.PalindromeSentence(str);
    }   
    
    
}
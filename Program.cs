
// 1-vazifa
System.Console.WriteLine("Ture 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

    int counter = 1;
    while(counter < firstNumber)
    {
        System.Console.WriteLine(counter);
        counter += 2;
    }


// 2.chi vazifa
int[] number = {6, 9, 8, 4, 85, 7, 125, 5} ;
Array.Sort(number);

for(int iterator = 0 ; iterator < number.Length; iterator += number.Length) 
{
   
   for(int innerIterator = number.Length-1;  innerIterator <= number.Length; innerIterator++)
   {
      System.Console.WriteLine($"{number[iterator]} x {number[innerIterator]} = {number[iterator] * number[innerIterator]}");
   }  
}


// 3.chi vazifa
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
int i = 1;

while(i <= n)
{
    System.Console.WriteLine($"{factorial=factorial*i}");
    i++;
}





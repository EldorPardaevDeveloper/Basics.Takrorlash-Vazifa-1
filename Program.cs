
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
int[] number = {1, 2, 3, 4, 5, 6, 7, 8} ;
for(int iterator = 1; iterator <= number.Length; iterator+=8) 

for(int innerIterator = 8; innerIterator == number.Length; innerIterator++)
{
    System.Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
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





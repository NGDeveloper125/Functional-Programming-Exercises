
namespace FunctionalCodingExercises;

public static class PrimeNumbersExercise{

    public static void PrintPrimeNumbers(int range) =>
                        Enumerable.Range(0, range).Where(IsPrime).ToList().ForEach(Console.WriteLine);
    
    private static bool IsPrime(int number) => 
                        number switch
                        {
                            < 2 => false,
                            2 => true,
                            _ => Enumerable.Range(2, number - 2).All(x => number % x != 0)
                        };  
}
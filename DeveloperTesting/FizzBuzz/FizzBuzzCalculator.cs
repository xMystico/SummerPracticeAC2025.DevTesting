namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int number)
            => number % 15 == 0
                ? "FizzBuzz"
                : number % 3 == 0
                    ? "Fizz"
                    : number % 5 == 0
                        ? "Buzz"
                        : number.ToString();
    }
}

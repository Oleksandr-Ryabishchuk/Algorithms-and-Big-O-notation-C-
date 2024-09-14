Here are a few implementations of the Fibonacci algorithm

1. Fibonacci recursive
   public static int Fibonacci(int input)
   {
      if (input <= 2)
      {
          return 1;
      }
  
      return Fibonacci(input - 1) + Fibonacci(input - 2);
   }

It has a time complexity of 2^N because it contains two recursive functions for every input that is bigger than the number 2
The space complexity of this algorithm is N because the number of variables is steady and grows no faster than the input

2. Fibonnaci iterative
   public static int Fibonacci(int input)
   {
      int a = 0, b = 1, temp;
  
      for (int i = 0; i < input; i++)
      {
          temp = a;
          a = b;
          b = temp + b;
      }
  
      return a;
   }

An iterative solution has a time complexity of N because it contains N iterations
The space complexity of the iterative implementation is 1 because the number of variables does not grow with input N

3. Fibonacci using Binet's formula
   public static double Fibonacci(int input)
   {
       double phi = (1 + Math.Sqrt(5)) / 2;
       double psi = (1 - Math.Sqrt(5)) / 2;
         
       return Math.Floor((Math.Pow(phi, input) - Math.Pow(psi, input)) / Math.Sqrt(5));
   }
   
The time complexity of Fibonacci calculated by Binet's formula is 1 because it uses constant time to account for exactly 1 time
The space complexity is also 1 because only a few variables are used and they do not grow 

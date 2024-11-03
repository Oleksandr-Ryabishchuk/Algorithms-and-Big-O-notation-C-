using Fibonacci;
using System;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
long output = FibonacciRecursiveImplementation.Fibonacci(50);
stopwatch.Stop();

Console.WriteLine(output);
Console.WriteLine($"Execution Time for Recursive Implementation: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

stopwatch.Start();
output = FibonacciIterativeImplementation.Fibonacci(50);
stopwatch.Stop();

Console.WriteLine(output);
Console.WriteLine($"Execution Time for Iterative Implementation: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

stopwatch.Start();
output = FibonacciBinetsImplementation.Fibonacci(50);
stopwatch.Stop();

Console.WriteLine(output);
Console.WriteLine($"Execution Time for Binets Implementation: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

stopwatch.Start();
var fibMemo = new FibonacciMemoImplementation();
var outputMemo = fibMemo.Fibonacci(50);
stopwatch.Stop();

Console.WriteLine(outputMemo);
Console.WriteLine($"Execution Time for Memoized Implementation: {stopwatch.ElapsedMilliseconds} ms");

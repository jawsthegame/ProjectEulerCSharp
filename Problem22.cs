using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerTom {
	public class Problem22 {
		public static void Run() {
			/*
			Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
			If d(a) = b and d(b) = a, where a  b, then a and b are an amicable pair and each of a and b are called amicable numbers.

			For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

			Evaluate the sum of all the amicable numbers under 10000.
			*/
			var sum = 0;
			for (var i = 1; i < 10000; i++) {
				if (i == SumOfDivisors(SumOfDivisors(i)) && i != SumOfDivisors(i)) {
					sum += i;
					Console.WriteLine("Amicable number: {0}", i);
				}
			}

			Console.WriteLine("Sum: {0}", sum);
			Console.ReadKey();
		}

		static int SumOfDivisors(int n) {
			var sum = 1; //all numbers have 1 as a divisor
			for (var i = 2; i <= Math.Sqrt(n); i++) {
				if (n % i == 0) {
					sum += i == n / i ? i : i + (n / i);
				}
			}
			return sum;
		}
	}
}

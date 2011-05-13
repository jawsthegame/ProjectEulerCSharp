using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerTom {
	public class Problem23 {
		public static void Run() {
			/*
				A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
				For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

				A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

				As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum 
				of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can 
				be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis 
				even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less 
				than this limit.

				Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
		*/

			var sum = 0;
			for (var i = 1; i <= 28123; i++) {
				if (CannotBeWrittenAsSum(i)) sum += i;
			}

			Console.WriteLine("Sum: {0}", sum);
			Console.ReadKey();
		}

		static bool CannotBeWrittenAsSum(int n) {
			for (var i = 1; i <= n / 2; i++) {
				if (IsAbundant(i) && IsAbundant(n - i)) {
					return false;
				}
			}
			return true;
		}

		static bool IsAbundant(int n) {
			return SumOfDivisors(n) > n;
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

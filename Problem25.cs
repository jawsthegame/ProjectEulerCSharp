using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEulerTom {
	public class Problem25 {
		static long count = 0;

		public static void Run() {
			NextFibonacci(1, 1);
			Console.ReadKey();
		}

		static BigInteger NextFibonacci(BigInteger a, BigInteger b) {
			count++;
			if (BigInteger.Log10(a) >= 999) {
				Console.WriteLine(count);
				return 0;
			}
			return NextFibonacci(b, a + b);
		}
	}
}

using System;

namespace RandPi {
	class Pi {
		//vars

		//constructor
		public Pi() {

		}

		//public
		public static BigDecimal calculate() {
			BigDecimal sum = 0.0d;
			for (int k = 0; k < 28; k++) {
				sum += (Math.Pow(-1.0, k) * factorial(6.0 * k) * (13591409.0 + (545140134.0 * k)))
					/ (factorial(3.0 * k) * Math.Pow(factorial(k), 3.0) * Math.Pow(640320.0, 3.0 * k + 3.0 / 2.0));
			}
			sum *= 12.0d;
			sum = 1.0d / sum;
			return sum;
		}

		//private
		private static double factorial(double f) {
			double result = 1.0d;
			for (int i = 2; i < f; i++) {
				result *= i;
			}
			return result;
		}
	}
}

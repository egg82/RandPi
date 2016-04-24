using System;
using System.IO;
using System.Numerics;

namespace RandPi {
	class Program {
		//vars
		private static BigDecimal pi;
		private static string cache;

		private static Rand random;

		public const string DoubleFixedPoint = "0.###################################################################################################################################################################################################################################################################################################################################################";

		//constructor
		static void Main(string[] args) {
			BigDecimal.Precision = 31415;

			Console.WriteLine("Calculating Pi..");
			pi = Pi.calculate();
			Console.WriteLine("Creating cache..");
			cache = pi.Mantissa.ToString();
			Console.WriteLine("Generating numbers..");

			random = new Rand(pi, cache);
			/*random.getNumAt(1);
			random.getNumAt(10);
			random.getNumAt(100);
			random.getNumAt(1000);
			random.getNumAt(10000);
			random.getNumAt(100000);
			random.getNumAt(1000000);
			random.getNumAt(10000000);
			random.getNumAt(100000000);*/
			/*Console.WriteLine(random.getNumAt(1).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(10).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(100).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(1000).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(10000).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(100000).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(1000000).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(10000000).ToString(DoubleFixedPoint));
			Console.WriteLine(random.getNumAt(100000000).ToString(DoubleFixedPoint));*/

			/*for (int i = 0; i < 1000; i++) {
				double retVal = random.getNumAt(i);
				double retVal2 = random.getNumAt(i + 1000);
				double retVal3 = random.getNumAt(i + 2000);
				//if (retVal == 0.0d || retVal2 == 0.0d || retVal3 == 0.0d) {
					Console.WriteLine(i + ": " + retVal.ToString(DoubleFixedPoint)
						+ "\t\t\t\t" + (i + 1000) + ": " + retVal2.ToString(DoubleFixedPoint)
						+ "\t\t\t\t" + (i + 2000) + ": " + retVal3.ToString(DoubleFixedPoint)
					);
				//}
			}*/

			/*using (StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + "\\test.txt", false)) {
				for (int i = 0; i < 1000000; i++) {
					file.Write(random.getNumAt(i));
				}
			}*/
			for (int i = 0; i < 100000; i++) {
				Console.WriteLine(random.normalize(random.getNumAt(i)).ToString(DoubleFixedPoint));
			}

			Console.WriteLine("Done!");

			//Console.WriteLine(cache);

			Console.Read();
		}

		//public

		//private

	}
}

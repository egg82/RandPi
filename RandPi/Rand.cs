using System;
using System.Numerics;

namespace RandPi {
	class Rand {
		//vars
		private BigDecimal maxNum;
		private string cache;
		private int length;

		//constructor
		public Rand(BigDecimal pi, string cache) {
			this.cache = cache;
			length = cache.Length;
			maxNum = new BigDecimal(pi.Mantissa, 0);
		}

		//public
		public ulong getNumAt(int index) {
			index = normalizeIndex((double) index);
			
			int size = ((int) char.GetNumericValue(cache[index])) + 1;
			string built = "";
			for (int i = 1; i <= size; i++) {
				index += (index % 2 == 0) ? i << size : (i << size) * -1;
				index = normalizeIndex((double) index);
				built += cache[index];
			}
			
			return ulong.Parse(built);
		}

		public double normalize(ulong num) {
			return ((double) num) / 9999999999.0d;
		}

		//private
		private int normalizeIndex(double index) {
			double tempIndex = index;
			int iterations = 1;
			do {
				if (tempIndex >= length) {
					tempIndex -= length;
				}
				if (tempIndex < 0) {
					tempIndex += length;
				}
				if (tempIndex != index) {
					int size = tempIndex.ToString().Length;
					tempIndex += (tempIndex % 2 == 0) ? iterations << size : (iterations << size) * -1;
					iterations++;
					index = tempIndex;
				}
			} while (tempIndex >= length || tempIndex < 0);

			return (int) tempIndex;
		}
	}
}

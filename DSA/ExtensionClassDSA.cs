using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA {
    public static class ExtensionClassDSA {
        public static void InsertionSort(this int[] numbers) {
            int n = numbers.Length;

            for(int i = 1; i <= n - 1; i++ ) {
                int cur = numbers[i];

                int j = i;

                while (j > 0 && numbers[j - 1] > cur) {
                    numbers[j] = numbers[j - 1];
                    j--;
                }

                numbers[j] = cur;
            }
        }
    }
}

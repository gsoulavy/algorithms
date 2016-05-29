using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class Fibonacci
    {
        private static readonly Dictionary<int, double> _memo = new Dictionary<int, double>();

        public static double Calculate(int n)
        {
            var memoResult = _memo.Get(n);
            if (memoResult != null) return memoResult.Value;
            var result = n < 2 ? (double)n : Calculate(n - 1) + Calculate(n - 2);
            _memo[n] = result;
            return result;
        }

        private static double? Get(this Dictionary<int, double> memo, int index)
        {
            if (memo.ContainsKey(index)) return memo[index];
            return null;
        }
    }

    public static class DictionaryExtension
    {
        public static double Fibonacci(this Dictionary<int, double> dictionary, int n)
        {
            double? memoResult = null;
            if (dictionary.ContainsKey(n)) memoResult = dictionary[n];
            if (memoResult != null) return memoResult.Value;
            var result = n < 2 ? (double)n : dictionary.Fibonacci(n - 1) + dictionary.Fibonacci(n - 2);
            dictionary[n] = result;
            return result;
        }

        public static Dictionary<int, double> FibonacciSequence(this Dictionary<int, double> dictionary, int n)
        {
            dictionary.Fibonacci(n);
            return dictionary.OrderBy(d => d.Key).ToDictionary(d => d.Key, (d) => d.Value);
        }
    }
}
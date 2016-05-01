namespace Algorithms
{
    public static class Sort
    {
        public static int[] MergeSort(int[] sequence)
        {
            var halfLength = sequence.Length / 2;
            var left = new int[halfLength];
            var right = new int[sequence.Length - halfLength];

            for (var i = 0; i < sequence.Length; i++)
            {
                if (i < halfLength)
                {
                    left[i] = sequence[i];
                }
                else
                {
                    right[i - halfLength] = sequence[i];
                }
            }

            if ((left.Length + right.Length) > 2)
            {
                left = MergeSort(left);
                right = MergeSort(right);
            }

            var leftCount = 0;
            var rightCount = 0;
            for (var i = 0; i < sequence.Length; i++)
            {
                var l = (leftCount < left.Length) ? left[leftCount] : new int?();
                var r = (rightCount < right.Length) ? right[rightCount] : new int?();

                if (l < r || r == null)
                {
                    if (l != null) sequence[i] = l.Value;
                    leftCount++;
                }
                else if (r < l || l == null)
                {
                    sequence[i] = r.Value;
                    rightCount++;
                }
            }
            return sequence;
        }

        public static int[] InsertionSort(int[] sequence)
        {
            for (var j = 1; j < sequence.Length; j++)
            {
                var value = sequence[j];
                var i = j;
                while (i > 0 && sequence[i - 1] > value)
                {
                    sequence[i] = sequence[i - 1];
                    sequence[i - 1] = value;
                    i--;
                }
            }
            return sequence;
        }

        public static int[] SelectionSort(int[] sequence)
        {
            for (var j = 0; j < sequence.Length - 1; j++)
            {
                var min = sequence[j];
                var index = j;
                for (var i = j; i < sequence.Length; i++)
                {
                    if (sequence[i] < min)
                    {
                        min = sequence[i];
                        index = i;
                    }
                }
                if (sequence[j] != min)
                {
                    sequence[index] = sequence[j];
                    sequence[j] = min;
                }
            }
            return sequence;
        }
    }
}
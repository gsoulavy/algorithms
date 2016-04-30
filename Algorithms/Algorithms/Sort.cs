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
    }
}
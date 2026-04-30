using System.Numerics;

namespace Combinations
{
    public class Class1
    {
        //Given two integers n and k,
        /// <summary>
        /// /return all possible combinations of k numbers chosen from the range [1, n].
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> combine(int n, int k)
        {
            var result = new List<List<int>>();
            int firstDigit = 1;
            int secondDigit = firstDigit+1;
            if (n == 1)
            {
                result.Add(new List<int>() { 1 });
            }

            while (firstDigit < n)
            {
                var subList = new List<int>();
                result.Add(combineHelper(firstDigit, secondDigit, k, subList));
                if(secondDigit<n)
                {
                    secondDigit++;
                }
                else
                {
                    firstDigit++;
                    secondDigit = firstDigit + 1;
                }
            }
            return result;
        }

        private List<int> combineHelper(int firstDigit, int secondDigit, int size, List<int> subList)
        {
            subList.Add(firstDigit);
            while (subList.Count < size) 
            {
                subList.Add(secondDigit);
                secondDigit++;
            }
            return subList;
        }
    }
}

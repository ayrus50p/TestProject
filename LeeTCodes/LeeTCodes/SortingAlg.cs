namespace LeeTCodes
{
    public class longestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            strs = new string[] { "flower", "flow", "flight" };
            if (strs == null || strs.Length == 0)
                return "";
            return LongestCommonPrefix(strs, 0, strs.Length - 1);
        }

        private string LongestCommonPrefix(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            else
            {
                int mid = (l + r) / 2;
                var lcpLeft = LongestCommonPrefix(strs, l, mid);
                var lcpRight = LongestCommonPrefix(strs, mid + 1, r);
                return CommonPrefix(lcpLeft, lcpRight);
            }
        }

        private string CommonPrefix(string left, string right)
        {
            int min = Math.Min(left.Length, right.Length);
            for (int i = 0; i < min; i++)
            {
                if (left[i] != right[i])
                    return left.Substring(0, i);
            }

            return left.Substring(0, min);
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            strs = new string[] {"flower", "flow", "flight" };
            if (strs == null || strs.Length == 0)
                return "";
            int minLen = Int32.MaxValue;
            foreach (string str in strs) minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (IsCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }

            return strs[0].Substring(0, (low + high) / 2);
        }

        private bool IsCommonPrefix(string[] strs, int len)
        {
            string str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
    public class SortingAlg
    {



        public void InsertionSort()
        {
            int[] nums = new int[] { 23, 34, 12, 54, 23, 25 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }


            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }


        public void SelectionSort()
        {
            int[] nums = new int[] { 23, 34, 12, 54, 26, 25 };

            int min = 0;
            for(int i=0;i<nums.Length;i++) 
            {
                min = i;

                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }


                if(min!=i)
                {
                    int temp = nums[i];
                    nums[i] = nums[min];
                    nums[min] = temp;
                }
            }

            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
        }


        public void BubbleSort()
        {
            var arraylist = new int[] { 89, 76, 45, 92, 67, 12, 99 };

            for(int i=0;i<arraylist.Length;i++)
            {
                for(int j=0;j<arraylist.Length-1;j++)
                {
                    if (arraylist[j]>arraylist[j+1])
                    {
                        int temp = arraylist[j];
                        arraylist[j]= arraylist[j+1];
                        arraylist[j+1] = temp;
                    }
                }
            }


            foreach(var i in arraylist)
            {
                Console.WriteLine(i);
            }

        }

        public void polindrome(string s)
        {
            s = s.Trim();
            var charArray = s.ToCharArray();
            int len = s.Length;
            int min = 0;
            int max = len - 1;

            while (true)
            {
                if(min>=max)
                {
                    Console.WriteLine("it is polindrome");
                    break;

                }
                if (charArray[min] != charArray[max])
                {
                    Console.WriteLine("It is not polindrome string");
                    break;
                }
                min++;
                max--;
            }

        }


    }

}
using System;
using System.Collections.Generic;
using System.Numerics; // Required for BigInteger

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array ==================================
            Console.WriteLine("Question 1: ==================================");

            // Array with missing numbers and duplicates
            // the function can handle duplicates and find missing numbers
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine("Input: " + string.Join(",", nums1));
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine("Output: " + string.Join(",", missingNumbers));
            Console.WriteLine();
            // Console.WriteLine(string.Join(",", missingNumbers));

            // Array with all numbers present
            // the function should return an empty list and it does
            int[] nums1b = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Input: " + string.Join(",", nums1b));
            IList<int> missingNumbers2 = FindMissingNumbers(nums1b);
            // Console.WriteLine(string.Join(",", missingNumbers2));
            Console.WriteLine("Output: " + string.Join(",", missingNumbers2));
            Console.WriteLine();

            // Array with out-of-bounds values
            // the function should show an error and it does
            int[] nums1c = { 1, 2, 3, 4, 6, 7 };
            Console.WriteLine("Input: " + string.Join(",", nums1c));
            IList<int> missingNumbers3 = FindMissingNumbers(nums1c);
            // Console.WriteLine(string.Join(",", missingNumbers3));
            Console.WriteLine("Output: " + string.Join(",", missingNumbers3));
            Console.WriteLine();

            // Array with negative numbers
            // the function should show an error and it does
            int[] nums1d = { -1, -2, -3, -4, -5 };
            Console.WriteLine("Input: " + string.Join(",", nums1d));
            IList<int> missingNumbers4 = FindMissingNumbers(nums1d);
            // Console.WriteLine(string.Join(",", missingNumbers4));
            Console.WriteLine("Output: " + string.Join(",", missingNumbers4));
            Console.WriteLine();

            // Question 2: Sort Array by Parity ==================================
            Console.WriteLine("Question 2: ==================================");

            // Array with mixed even and odd numbers
            // the function should return an array with even numbers first
            // and odd numbers last, maintaining the relative order
            // of even and odd numbers
            int[] nums2 = { 3, 1, 2, 4 };
            Console.WriteLine("Input: " + string.Join(",", nums2));
            int[] sortedArray = SortArrayByParity(nums2);
            // Console.WriteLine(string.Join(",", sortedArray));
            Console.WriteLine("Output: " + string.Join(",", sortedArray));
            Console.WriteLine();

            // Array with all even numbers
            // the function should return the same array
            // as the input array
            int[] nums2b = { 2, 4, 6, 8 };
            Console.WriteLine("Input: " + string.Join(",", nums2b));
            int[] sortedArray2 = SortArrayByParity(nums2b);
            // Console.WriteLine(string.Join(",", sortedArray2));
            Console.WriteLine("Output: " + string.Join(",", sortedArray2));
            Console.WriteLine();

            // Array with all odd numbers
            // the function should return the same array
            // as the input array
            int[] nums2c = { 1, 3, 5, 7 };
            Console.WriteLine("Input: " + string.Join(",", nums2c));
            int[] sortedArray3 = SortArrayByParity(nums2c);
            // Console.WriteLine(string.Join(",", sortedArray3));
            Console.WriteLine("Output: " + string.Join(",", sortedArray3));
            Console.WriteLine();

            // Array with no numbers
            // the function should return an empty array
            // as the input array
            int[] nums2d = { };
            Console.WriteLine("Input: " + string.Join(",", nums2d));
            int[] sortedArray4 = SortArrayByParity(nums2d);
            // Console.WriteLine(string.Join(",", sortedArray4));
            Console.WriteLine("Output: " + string.Join(",", sortedArray4));
            Console.WriteLine();

            // Array with one number
            // the function should return the same array
            // as the input array
            int[] nums2e = { 1 };
            Console.WriteLine("Input: " + string.Join(",", nums2e));
            int[] sortedArray5 = SortArrayByParity(nums2e);
            // Console.WriteLine(string.Join(",", sortedArray5));
            Console.WriteLine("Output: " + string.Join(",", sortedArray5));
            Console.WriteLine();



            // Question 3: Two Sum ==================================
            Console.WriteLine("Question 3: ==================================");

            // Array with two numbers that add up to the target
            // the function should return the indices of the two numbers
            // that add up to the target
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine("Input: " + string.Join(",", nums3));
            Console.WriteLine("Target: " + target);
            int[] indices = TwoSum(nums3, target);
            // Console.WriteLine(string.Join(",", indices));
            // write imput and taarget
            Console.WriteLine("Output: " + string.Join(",", indices));
            Console.WriteLine();

            // Array with no two numbers that add up to the target
            // the function should throw an exception
            // and it does
            int[] nums3b = { 1, 2, 3, 4, 5 };
            int target2 = 10;
            Console.WriteLine("Input: " + string.Join(",", nums3b));
            Console.WriteLine("Target: " + target2);
            int[] indices2 = TwoSum(nums3b, target2);
            // Console.WriteLine(string.Join(",", indices2));
            Console.WriteLine("Output: " + string.Join(",", indices2));
            Console.WriteLine();

            // The case with multiple pairs that add up to the target
            // the function should return the first pair it finds
            // and it does
            int[] nums3b2 = { 3, 2, 4, 5 };
            int target3b2 = 7;
            Console.WriteLine("Input: " + string.Join(",", nums3b2));
            Console.WriteLine("Target: " + target3b2);
            int[] indices3b2 = TwoSum(nums3b2, target3b2);
            // Console.WriteLine(string.Join(",", indices3b2));
            Console.WriteLine("Output: " + string.Join(",", indices3b2));
            Console.WriteLine();

            // Array with negative numbers
            // the function should return the indices of the two numbers
            // that add up to the target
            int[] nums3c = { -1, -2, -3, -4, -5 };
            int target3 = -8;
            Console.WriteLine("Input: " + string.Join(",", nums3c));
            Console.WriteLine("Target: " + target3);
            int[] indices3 = TwoSum(nums3c, target3);
            // Console.WriteLine(string.Join(",", indices3));
            Console.WriteLine("Output: " + string.Join(",", indices3));
            Console.WriteLine();

            // Array with one number
            // the function should throw an exception
            // and it does
            int[] nums3d = { 1 };
            int target4 = 2;
            Console.WriteLine("Input: " + string.Join(",", nums3d));
            Console.WriteLine("Target: " + target4);
            int[] indices4 = TwoSum(nums3d, target4);
            // Console.WriteLine(string.Join(",", indices4));
            Console.WriteLine("Output: " + string.Join(",", indices4));
            Console.WriteLine();

            // Question 4: Find Maximum Product of Three Numbers ==================================
            Console.WriteLine("Question 4: ==================================");

            // Array with positive numbers
            // the function should return the maximum product
            // of three numbers
            int[] nums4 = { 1, 2, 3, 4 };
            Console.WriteLine("Input: " + string.Join(",", nums4));
            int maxProduct = MaximumProduct(nums4);
            // Console.WriteLine(maxProduct);
            Console.WriteLine("Output: " + maxProduct);
            Console.WriteLine();

            // Array with negative numbers
            // the function should return 0
            // because the function only accepts positive integers
            int[] nums4b = { -1, -2, 5, -4 };
            Console.WriteLine("Input: " + string.Join(",", nums4b));
            int maxProduct2 = MaximumProduct(nums4b);
            // Console.WriteLine(maxProduct2);
            Console.WriteLine("Output: " + maxProduct2);
            Console.WriteLine();

            // Array with less than three numbers
            // the function should return 0
            // because the function only accepts arrays with at least three numbers
            int[] nums4c = { 1, 2 };
            Console.WriteLine("Input: " + string.Join(",", nums4c));
            int maxProduct3 = MaximumProduct(nums4c);
            // Console.WriteLine(maxProduct3);
            Console.WriteLine("Output: " + maxProduct3);
            Console.WriteLine();

            // Array with all numbers the same
            // the function should return the product of three numbers
            // that are the same
            int[] nums4d = { 2, 2, 2, 2 };
            Console.WriteLine("Input: " + string.Join(",", nums4d));
            int maxProduct4 = MaximumProduct(nums4d);
            // Console.WriteLine(maxProduct4);
            Console.WriteLine("Output: " + maxProduct4);
            Console.WriteLine();

            // Question 5: Decimal to Binary Conversion ==================================
            Console.WriteLine("Question 5: ==================================");

            // Decimal number to convert
            // the function should return the binary representation
            // of the decimal number
            // the function should return "101010"
            // for the decimal number 42
            int decimalNumber = 42;
            Console.WriteLine("Input: " + decimalNumber);
            string binary = DecimalToBinary(decimalNumber);
            // Console.WriteLine(binary);
            Console.WriteLine("Output: " + binary);
            Console.WriteLine();

            // Decimal number 0
            // the function should return "0"
            int decimalNumber2 = 0;
            Console.WriteLine("Input: " + decimalNumber2);
            string binary2 = DecimalToBinary(decimalNumber2);
            // Console.WriteLine(binary2);
            Console.WriteLine("Output: " + binary2);
            Console.WriteLine();

            // Decimal number negative
            // the function should print error massage
            // and return "0"
            int decimalNumber3 = -42;
            Console.WriteLine("Input: " + decimalNumber3);
            string binary3 = DecimalToBinary(decimalNumber3);
            // Console.WriteLine(binary3);
            Console.WriteLine("Output: " + binary3);
            Console.WriteLine();

            // a very large decimal number
            // the function should return the binary representation
            // of the decimal number
            int decimalNumber5 = 1234567890;
            Console.WriteLine("Input: " + decimalNumber5);
            string binary5 = DecimalToBinary(decimalNumber5);
            // Console.WriteLine(binary5);
            Console.WriteLine("Output: " + binary5);
            Console.WriteLine();

            // Question 6: Find Minimum in Rotated Sorted Array ==================================
            Console.WriteLine("Question 6: ==================================");

            // Rotated sorted array
            // the function should return the minimum element
            // in the rotated sorted array
            // the function should return 1
            int[] nums5 = { 3, 4, 5, 1, 2 };
            Console.WriteLine("Input: " + string.Join(",", nums5));
            int minElement = FindMin(nums5);
            // Console.WriteLine(minElement);
            Console.WriteLine("Output: " + minElement);
            Console.WriteLine();

            // Rotated sorted array with duplicates
            // the function should return the minimum element
            // in the rotated sorted array
            // the function should return 0
            int[] nums5b = { 2, 2, 2, 0, 1 };
            Console.WriteLine("Input: " + string.Join(",", nums5b));
            int minElement2 = FindMin(nums5b);
            // Console.WriteLine(minElement2);
            Console.WriteLine("Output: " + minElement2);
            Console.WriteLine();

            // Rotated sorted array with all elements the same
            // the function should return the minimum element
            // in the rotated sorted array
            // the function should return 2
            int[] nums5c = { 2, 2, 2, 2, 2 };
            Console.WriteLine("Input: " + string.Join(",", nums5c));
            int minElement3 = FindMin(nums5c);
            // Console.WriteLine(minElement3);
            Console.WriteLine("Output: " + minElement3);
            Console.WriteLine();

            // Rotated sorted array with one element
            // the function should return the minimum element
            // in the rotated sorted array
            // the function should return 1
            int[] nums5d = { 1 };
            Console.WriteLine("Input: " + string.Join(",", nums5d));
            int minElement4 = FindMin(nums5d);
            // Console.WriteLine(minElement4);
            Console.WriteLine("Output: " + minElement4);
            Console.WriteLine();

            // Rotated sorted array with no elements
            // the function should return 0
            int[] nums5e = { };
            Console.WriteLine("Input: " + string.Join(",", nums5e));
            int minElement5 = FindMin(nums5e);
            // Console.WriteLine(minElement5);
            Console.WriteLine("Output: " + minElement5);
            Console.WriteLine();

            // Rotated sorted array with negative numbers
            // the function should show and errir message and return 0
            // the function should return 0
            int[] nums5f = { -1, -2, -3, -4, -5 };
            Console.WriteLine("Input: " + string.Join(",", nums5f));
            int minElement6 = FindMin(nums5f);
            // Console.WriteLine(minElement6);
            Console.WriteLine("Output: " + minElement6);
            Console.WriteLine();

            // Question 7: Palindrome Number ==================================
            Console.WriteLine("Question 7: ==================================");

            // Palindrome number
            // the function should return true
            // for the palindrome number
            int palindromeNumber = 121;
            Console.WriteLine("Input: " + palindromeNumber);
            bool isPalindrome = IsPalindrome(palindromeNumber);
            // Console.WriteLine(isPalindrome);
            Console.WriteLine("Output: " + isPalindrome);
            Console.WriteLine();

            // Non-palindrome number
            // the function should return false
            // for the non-palindrome number
            int nonPalindromeNumber = 123;
            Console.WriteLine("Input: " + nonPalindromeNumber);
            bool isPalindrome2 = IsPalindrome(nonPalindromeNumber);
            // Console.WriteLine(isPalindrome2);
            Console.WriteLine("Output: " + isPalindrome2);
            Console.WriteLine();

            // Negative number
            // the function should return false
            // for the negative number
            int negativeNumber = -121;
            Console.WriteLine("Input: " + negativeNumber);
            bool isPalindrome3 = IsPalindrome(negativeNumber);
            // Console.WriteLine(isPalindrome3);
            Console.WriteLine("Output: " + isPalindrome3);
            Console.WriteLine();

            // Single digit number
            // the function should return true
            // for the single digit number
            int singleDigitNumber = 7;
            Console.WriteLine("Input: " + singleDigitNumber);
            bool isPalindrome4 = IsPalindrome(singleDigitNumber);
            // Console.WriteLine(isPalindrome4);
            Console.WriteLine("Output: " + isPalindrome4);
            Console.WriteLine();

            // Zero
            // the function should return true
            // for the zero number
            int zeroNumber = 0;
            Console.WriteLine("Input: " + zeroNumber);
            bool isPalindrome5 = IsPalindrome(zeroNumber);
            // Console.WriteLine(isPalindrome5);
            Console.WriteLine("Output: " + isPalindrome5);
            Console.WriteLine();

            // Large palindrome number
            // the function should return true
            // for the large palindrome number
            BigInteger largePalindromeNumber = BigInteger.Parse("1234567890987654321");
            Console.WriteLine("Input: " + largePalindromeNumber);
            bool isPalindrome6 = IsPalindrome(largePalindromeNumber);
            // Console.WriteLine(isPalindrome6);
            Console.WriteLine("Output: " + isPalindrome6);
            Console.WriteLine();

            // Large non-palindrome number
            // the function should return false
            // for the large non-palindrome number
            BigInteger largeNonPalindromeNumber = BigInteger.Parse("1234567890987654322");
            Console.WriteLine("Input: " + largeNonPalindromeNumber);
            bool isPalindrome7 = IsPalindrome(largeNonPalindromeNumber);
            // Console.WriteLine(isPalindrome7);
            Console.WriteLine("Output: " + isPalindrome7);
            Console.WriteLine();

            // Question 8: Fibonacci Number ===================================
            Console.WriteLine("Question 8: ==================================");

            // Fibonacci number
            // the function should return the Fibonacci number
            // for the given index
            int n = 4;
            Console.WriteLine("Input: " + n);
            int fibonacciNumber = Fibonacci(n);
            // Console.WriteLine(fibonacciNumber);
            Console.WriteLine("Output: " + fibonacciNumber);
            Console.WriteLine();

            // Fibonacci number with negative index
            // the function should return 0
            // for the negative index
            int n2 = -1;
            Console.WriteLine("Input: " + n2);
            int fibonacciNumber2 = Fibonacci(n2);
            // Console.WriteLine(fibonacciNumber2);
            Console.WriteLine("Output: " + fibonacciNumber2);
            Console.WriteLine();

            // Fibonacci number with index greater than 30
            // the function should return 0
            // for the index greater than 30
            int n3 = 31;
            Console.WriteLine("Input: " + n3);
            int fibonacciNumber3 = Fibonacci(n3);
            // Console.WriteLine(fibonacciNumber3);
            Console.WriteLine("Output: " + fibonacciNumber3);
            Console.WriteLine();

            // Fibonacci number with index 0
            // the function should return 0
            // for the index 0
            int n4 = 0;
            Console.WriteLine("Input: " + n4);
            int fibonacciNumber4 = Fibonacci(n4);
            // Console.WriteLine(fibonacciNumber4);
            Console.WriteLine("Output: " + fibonacciNumber4);
            Console.WriteLine();

            // Fibonacci number with index 1
            // the function should return 1
            // for the index 1
            int n5 = 1;
            Console.WriteLine("Input: " + n5);
            int fibonacciNumber5 = Fibonacci(n5);
            // Console.WriteLine(fibonacciNumber5);
            Console.WriteLine("Output: " + fibonacciNumber5);
            Console.WriteLine();
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                IList<int> missingNumbers = new List<int>();

                // Validate input: Ensure all numbers are within the range [1, nums.Length]
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < 1 || nums[i] > nums.Length)
                    {
                        // print the error message
                        Console.WriteLine($"Error: Array contains out-of-bounds value {nums[i]}.");
                        return missingNumbers;
                    }
                }

                // Mark the indices corresponding to the numbers in the array
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] = -nums[index];
                    }
                }

                // Find the indices that are still positive, which correspond to missing numbers
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        missingNumbers.Add(i + 1);
                    }
                }

                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                    return nums;

                // Validate all elements are integers
                foreach (var num in nums)
                {
                    if (num.GetType() != typeof(int))
                    {
                        Console.WriteLine($"Error: Array contains non-integer value {num}.");
                        return new int[] { };
                    }
                }

                int insertPos = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        int even = nums[i];
                        // Shift elements right to make space
                        for (int j = i; j > insertPos; j--)
                        {
                            nums[j] = nums[j - 1];
                        }
                        nums[insertPos] = even;
                        insertPos++;
                    }
                }

                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Create a dictionary to store the numbers and their indices
                Dictionary<int, int> numIndices = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    // Calculate the complement needed to reach the target
                    int complement = target - nums[i];

                    // Check if the complement exists in the dictionary
                    if (numIndices.ContainsKey(complement))
                    {
                        // Return the indices of the two numbers
                        return new int[] { numIndices[complement], i };
                    }

                    // Add the current number and its index to the dictionary
                    if (!numIndices.ContainsKey(nums[i]))
                    {
                        numIndices[nums[i]] = i;
                    }
                }

                // If no solution is found, throw an exception
                // print no sulution message and return an empty array
                Console.WriteLine($"Error: No two numbers add up to {target}.");
                return new int[] { };
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Validate input: Ensure all numbers are positive integers
                foreach (var num in nums)
                {
                    if (num <= 0)
                    {
                        // print the error message
                        Console.WriteLine($"Error: Array contains non-positive integer {num}.");
                        return 0;
                    }
                }

                // Sort the array
                Array.Sort(nums);

                // The maximum product is the product of the three largest numbers
                int n = nums.Length;
                if (n < 3)
                {
                    // print the error message
                    Console.WriteLine("Error: Array must contain at least three numbers.");
                    return 0;
                }

                int maxProduct = nums[n - 1] * nums[n - 2] * nums[n - 3];
                return maxProduct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber < 0)
                {
                    // print the error message and return a z=ero string
                    Console.WriteLine("Error: Input must be a non-negative integer.");
                    return "0";
                }

                // Handle the special case for 0
                if (decimalNumber == 0)
                {
                    return "0";
                }

                string binary = string.Empty;

                // Convert decimal to binary
                while (decimalNumber > 0)
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2;
                }

                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                {
                    // print the error message and return 0
                    Console.WriteLine("Error: Array must not be null or empty.");
                    return 0;
                }

                // if it has negative members return zero
                foreach (var num in nums)
                {
                    if (num < 0)
                    {
                        // print the error message and return 0
                        Console.WriteLine($"Error: Array contains negative integer {num}.");
                        return 0;
                    }
                }

                int left = 0, right = nums.Length - 1;

                // Binary search to find the minimum element
                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    // If mid element is greater than the rightmost element,
                    // the minimum is in the right half
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    // Otherwise, the minimum is in the left half (including mid)
                    else
                    {
                        right = mid;
                    }
                }

                // At the end of the loop, left == right, pointing to the minimum element
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(BigInteger x)
        {
            try
            {
                // Negative numbers are not palindromes
                if (x < 0)
                {
                    return false;
                }

                // Convert the number to a string
                string str = x.ToString();

                // Use two pointers to check if the string is a palindrome
                int left = 0, right = str.Length - 1;
                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Validate input: Ensure n is within the constraints
                if (n < 0 || n > 30)
                {
                    // print the error message and return 0
                    Console.WriteLine($"Error: Input must be between 0 and 30.");
                    return 0;
                }

                // Base cases
                if (n == 0) return 0;
                if (n == 1) return 1;

                // Iterative approach to calculate Fibonacci numbers
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                return b;
            }
            catch (ArgumentException ex)
            {
                // print the error message
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

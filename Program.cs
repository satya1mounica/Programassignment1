/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                /* ****LOGIC EXPLANATION*****
                 Here I have created a charcter array where I can store all the upper case and lower case
                vowels. And then comparing each and every character of the given string with character array which i have declared.
                Whereever both the characters matches, i am replacing that charaacter with ""
                Step by step explanation is against the statememnts.
                 */

                /* Time Taken: 2 hours
                   Learning: Debugging the code as the code which was executed for the first time was not giving the expected output
                   Reccomendation: Need to know the concept of nested loops.
                 */
                char[] ch = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }; //character array with all the vowels

                foreach (char c in ch) //looping for all the vowels as per the ch
                {
                    string dummystring = ""; // created a dummy string with "" to replace the vowels

                    for (int i = 0; i < s.Length; i++) // looped for the length of s
                    {
                        if (s[i] == c) //comparing each character of s string to ch array
                        {
                            dummystring = dummystring + ""; // if true, making dummystring with ""
                        }

                        else
                        {
                            dummystring = dummystring + s[i]; // if false, adding the non vowel of s string to dummy string
                        }
                    }

                    s = dummystring; // after the for loop is completed, assigning the dummy string to s string and running the foreach loop for all the vowels in the same way
                }
                String final_string = s;
                return final_string; // returning the final string

            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                /*
                 Time taken: 30 min
                 Learning: Strings can be concatinated with + in C#
                 Recommendations: Needs to understand the concept of arrays and loops.
                 */
                string new_bulls_string1 = ""; // Declaring 2 new strings to store the concatinated string
                string new_bulls_string2 = "";

                for (int i = 0; i < bulls_string1.Length; i++) // This loops concatinates bulls_string1 array elements to a sing string new_bulls_string1
                {
                    new_bulls_string1 = new_bulls_string1 + bulls_string1[i];
                }

                for (int j = 0; j < bulls_string2.Length; j++) // This loops concatinates bulls_string2 array elements to a sing string new_bulls_string2
                {
                    new_bulls_string2 = new_bulls_string2 + bulls_string2[j];
                }

                if (new_bulls_string1 == new_bulls_string2) // this condition compares the newly created string and returns true if the condition is satisified else returns false.
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                /*
                 Time taken: 2 hours
                 Learning: building the logic very carefully keeping in mind the ifs and buts
                 Recommendations: Should have crystal clear clarity on what is expected and how the compiler runs so to build the logic..
                 */
                int j = 0; // this variable is for looping purpose
                int unique = 0; // this variable is to store the unique number
                int UniqueSum = 0; // this variable is to store the sum of unique numbers.
                foreach (int n in bull_bucks) // this loop is to run for all the elements of the array.
                {

                    for (int i = 0; i < bull_bucks.Length; i++) // this loop is to find the unique values
                    {

                        if (i != j)
                        {
                            if (bull_bucks[j] != bull_bucks[i])
                            {
                                unique = bull_bucks[j];
                            }
                            else // if the value is not unique, compiler breaks.
                            {
                                unique = 0;
                                break;
                            }
                        }
                    }

                    j++;
                    UniqueSum = UniqueSum + unique; // this is to add all the unique values and store in unique sum
                }

                return UniqueSum;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.

                /*
                 Time taken: 2 hours
                 Learning: building the logic very carefully keeping in mind the ifs and buts. Concept of matrices
                 Recommendations: Should have crystal clear clarity on what is expected and how the compiler runs so to build the logic..
                 */
                int length = bulls_grid.GetLength(0); // this variable is to get the length of the rows or columns
                int SumOfDiagonal1 = 0; // this is to store the diagonal 1 sum
                int SumOfDiagonal2 = 0; // this is to store the diagonal 2 sum
                for (int i = 0; i < length; i++) // this loop derives the sum of diagonal 1
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i == j)
                        {
                            SumOfDiagonal1 = SumOfDiagonal1 + bulls_grid[i, j];
                        }
                    }
                }

                int k = length - 1;

                for (int i = 0; i < length; i++) //this loop derives the sum of diagonal 2 excluding the common elements
                {

                    if (i != k) // excluding the common index
                    {
                        SumOfDiagonal2 = SumOfDiagonal2 + bulls_grid[i, k];
                    }

                    k = k - 1;

                }
                return SumOfDiagonal1 + SumOfDiagonal2; // returning the sum of both the diagonals
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                /*
                 Time taken: 3 hours
                 Learning: building the logic very carefully keeping in mind the ifs and buts.
                 Recommendations: Should have crystal clear clarity on what is expected and how the compiler runs so to build the logic..
                 */
                int Length = indices.Length; //this variable is to store the length of the indices
                char[] Output = new char[Length]; //this variable is to store the output characters
                string AssembledString = ""; // this is to store the reassembled string

                for (int i = 0; i < Length; i++) // this loop is to assign the indices values to array index of the bulls_string
                {
                    int IndicesValue = indices[i];
                    Output[IndicesValue] = bulls_string[i];
                }

                for (int i = 0; i < Length; i++) // this loop is to derive the new string as per the output
                {
                    AssembledString = AssembledString + Output[i];
                }
                return AssembledString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {

                /*
                 Time taken: 4 hours
                 Learning: Strings and arrays concatination
                 Recommendations: Should have crystal clear clarity on what is expected and how the compiler runs to build the logic..
                 */
                String prefix_string = ""; // this variable is to store the prefix string after reversing it
                int Length1 = bulls_string6.Length; // to find the length of string
                string FirstHalf1 = ""; // this string is to break the first half od the string where the character matches
                string FirstHalf2 = ""; //this string is to add the character to the first half of the string
                string SecondHalf = ""; // this string is to store the second half od the string after the character matches.

                if (bulls_string6.Contains(ch)) // this condition checks if the character is present in the string or not.
                {

                    for (int i = 0; i < Length1; i++) // this loop seperates the first half od the string where character is found
                    {
                        if (bulls_string6[i] != ch)
                        {
                            FirstHalf1 = FirstHalf1 + bulls_string6[i];
                        }
                        else
                            break;
                    }

                    FirstHalf2 = FirstHalf1 + ch; // this statement concatinates the character to the derived string

                    int Length2 = FirstHalf2.Length;

                    for (int i = Length2; i < Length1; i++) // this loop derives the second half of the string
                    {
                        SecondHalf = SecondHalf + bulls_string6[i];
                    }

                    for (int i = Length2 - 1; i >= 0; i--) // this loop reverses the first half of the string
                    {
                        prefix_string = prefix_string + FirstHalf2[i];

                    }

                    return prefix_string + SecondHalf; // this conctinates the reversed string and the second half and returns the required string.

                }

                else
                    return bulls_string6;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
using Array.LeetCode;
using System.Globalization;
using System.Xml.Linq;

//int arrayLength = 10; // Define the length of the array
//int[] array = new int[arrayLength];
//int filledElements = 7; // Example: assume 7 elements are already filled


//List<int> list = new List<int>();
//// Populate the array with some initial values
//for (int i = 0; i < filledElements; i++)
//{
//    Console.Write($" Enter {filledElements} elements.");
//    array[i] = int.Parse(Console.ReadLine()); // Filling the array with values 1, 2, 3, 4, 5
//}

//ArrayFunctions functions = new ArrayFunctions();

//// Display the array before insertion
//Console.WriteLine("Array before insertion:");
//functions.PrintAllElemntsInAnArray(array);

//// Insert an element at the 3rd index (index 2)
//int elementToAdd = 10;
//int insertIndex = 2;

//functions.InsertElementAtIndex(array, insertIndex, elementToAdd, ref filledElements);

////Delete element at index n
//functions.DeleteElementAtIndex(array, 4, ref filledElements);

////Binary Searching an array
//functions.LinearSearch(array, 6);

////Arranging/Sortng eleements in Ascending
//functions.BubbleSortElementsinAscending(array, ref filledElements);

////Arranging/Sortng eleements in Descending
//functions.BubbleSortElementsinDescending(array, ref filledElements);

////Binary Search
//int result = functions.BinarySearch(array, ref filledElements, 10);
//functions.BinarySearchResult(result);

//Console.WriteLine("Enter the number you want to check for Palindrome and Armstrong number");
//int numToCheck= int.Parse(Console.ReadLine());

////Palindrome Check
//PalindromeCheck palindromeCheck = new PalindromeCheck();
//palindromeCheck.PalindromeCheckFunction(numToCheck);

////Armstrong Check
//ArmstrongCheck armstrongCheck = new ArmstrongCheck();
//armstrongCheck.ArmstrongCheckFunction(numToCheck);


// Leetcode Question no 66
//_66_PlusOne test = new _66_PlusOne();
//int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//int[] newArray = test.PlusOne(array);

//foreach (int i in newArray)
//{
//    Console.Write(" " + i);
//}


////LeetCode question number 26 
//int[] array = {1, 1, 2};
//_26_RemoveDuplicate test=new _26_RemoveDuplicate();
//int sol=test.RemoveDuplicates(array);
//Console.WriteLine(sol);

////LeetCode Question number 350 Intersection of Two Arrays II
//int[] nums1 = [4, 9, 5]; 
//int[] nums2 = [9, 4, 9, 8, 4];
//_350_IntersectionofTwoArraysII test = new _350_IntersectionofTwoArraysII();
//int[] sol = test.Intersect(nums1, nums2);
//foreach(int x in sol)
//{
//    Console.Write(x+" ");
//}

////Leetcode Question number #136 Single Number
//int[] nums1 = [4, 1, 2, 1, 2];
//_136_SingleNumber test=new _136_SingleNumber();
//int result = test.SingleNumber(nums1);
//Console.WriteLine(result);

////Leetcode Question number:- 283.Move Zeroes
//int[] nums = [0, 1, 0, 3, 12];
//_283_Move_Zeroes test=new _283_Move_Zeroes();
//int[] newArray = test.MoveZeroes(nums);
//foreach(int i in newArray)
//{
//    Console.WriteLine(i);
//}

////Leetcode Question number:- 268. Missing Number
//int[] nums = [3, 0, 1];
//_268_Missing_Number test=new _268_Missing_Number();
//int result = test.MissingNumber(nums);
//Console.WriteLine(result);

////Leetcode Question number:- 217. Contains Duplicate
//int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
//_217_Contains_Duplicate test=new _217_Contains_Duplicate();
//bool result = test.ContainsDuplicate(nums);
//Console.WriteLine(result);

////Leetcode Question number:- 88. Merge Sorted Array
//int[] nums1 = [1, 2, 3, 0, 0, 0];
//int[] nums2 = [2, 5, 6];
//int m = 3;
//int n = 3;
//_88_MergeSortedArray test=new _88_MergeSortedArray();
//test.Merge(nums1,m, nums2,n);

//Leetcode Question number:-169.Majority Element
_169_MajorityElement test=new _169_MajorityElement();
int[] nums = [2, 2, 1, 1, 1, 2, 2];
int result = test.MajorityElement(nums);
Console.WriteLine(result);











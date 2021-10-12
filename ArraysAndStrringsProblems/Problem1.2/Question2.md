# Question 2
Given two strings, check if one is a permutation of the other. One string is a __permutation__ of the other when it contains all and of the items in the other and only those items.

### Good Questions
* Are the characters sorted?

# Brute Force
* For each item in __a__ is check if it is in __b__. O(n^2)
* Sort both strings, if they are identical then one is a permutation of the other. O(n * log n) for Merge Sort.
* For each item in __a__ do a binary search in __b__. O(n * log n) since the binary search is done n times.

# My Answer
* Create a hash table/Dictionary<char,int>, for each char in __a__ increment the count by 1. Then loop through each char in __b__ and decrement the count by 1. It should all be zeroes, if you reach a negative or reach the end of __b__ with a value greater than 0, then return false. O(a + b) -> O(n) 

# CCI Answer
* Sort the strings. Then loop through both strings at the same time. If one does not equal the other, then return false; else true.
* Use an int vector (or a hash table) to count the occurance of a char by one. then using __b__ decrement the string. You should end up with all zeroes


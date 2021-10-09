# Question 1
Determine if a string has all unique characters. What if you can only use an array?

# Brute Force
* Loop through a string, for each char in the string find it it also in the string. If found then it there is a non unique item. If not continue. O(n^2). This can be optimized to use Binary Search to be O(n * log n)

# My Answer
* Loop through a string, for each char in the string, add it to a dictionary if it is already in a dictionary then there already is an item. Time Complexity O(n).

# CCI Answer
* Determine if something is either a ASCII or Unicode. ASCII is much simpler, contains less characters whereas Unicode has more possible representations for characters. Time Complexity: O(n).

## Steps
1. Create a bit vector (an array of booleans) that represents all possible values, this will initialize to all false.
2. Loop through the string in question, for each char in the string, check to see if that char's index is already true (if so return false), if not then set that value to true. the key used in the array is the char character. 

## What is the difference between ASCII and Unicode?
* [Geeks for Geeks](https://www.geeksforgeeks.org/ascii-vs-unicode/)

## What if you can only use an array?
* Then you would be limited to using looping through each char in the string and looking for that in the remaining substring.


# Question 3
Write a method to replace all spaces in a string with '%20'. Assume that the string has sufficient space at the end to hold additional characters and that you are given the true lenght of the string.

_input_ : ```"Mr John Smith   , 13```

_output_: ```Mr%20John%20Smith"```

### Good Questions
* Are the characters sorted?

# Brute Force
* Loop backwords in the string and insert the characters. O(n). Problem is that string are immutable.

# My Answer
* Loop through the string forward and create a new empty string. As you loop through the input string (_s_) add characters into the new string (_newS_) by appending to the string. When you reach the trueLenght, return the new string.
* Time Complexity: O(n)
* Space Complexity: O(a+b) space for each of the string, but _b_ is larger than a.

# CCI Answer
* Intake a char[], count the number of spaces to replace within the string to determine the new index. Then loop through the char[] char by char. When you encounter a space, change the values within the newIndex position and decrement the newIndex by 3 to account for the additional characters; Else just replace the value at the current index at the newIndex position and decrement the index by 1;
* Not sure if the char[] will always be long enough to contain all of the chars in the given string.


# Question 4
Given a string write a function to check if its a permutation of a palindrome. This is really asking if you can make a palindrome out of the string that is given to you. Ignore cases.

_input_ : ```"Tact Coa```

_output_: ```True (Taco Cat), (atco cta)```

### Good Questions
* What is a palindrome?
  * A palindrome is a word that results in the same word if it was read backwards and forwards. For example: hannah, taco cat
* What is a permutation?
  * A pemutation is just a rearragement of items in order.

# Brute Force & Analysis
* Thinking about the characteristics of the result to be true for something to be a palindrome the letters would either have to be even, or all except one as even. In the case of _taco cat_ all of the letters except 'o' occur twice (even).
* Using a Dictionary<char,int> we can keep track of how many occurances of a char happens to be. We'll ignore the spaces.
* We'll loop through each char in the string input and count how many times each char occurs. At the end we'll check if all of counts (or all except one) are even or not. 
* Time Complexity: O(n)

# My Answer
* Is also the brute force answer. lol

# CCI Answer
* The first solution happens to be the Brute Force since you'll have to go through all of the items in the input string. But you can make small optimizations to the code.


# Question 4
You can do 3 types of edits to a string: insert, remove, replace. Given 2 strings check to see if they are one edit away.

_input_ -> _output_: ```ple, pale``` -> ``` true```

_input_ -> _output_: ```pale, bae``` -> ``` false```


# Brute Force & Analysis
* Thinking about the items that you can do, insert, remove, replace and that in a __true__ you can only do one of these moves the following has to be true:
  * both strings can be off by one and only one.
  * both strings have generally the same order.
* Loop through the entire string of _a_, and check to see if its the same char in _b_. 
    * If not, then increment a counter by one. If the counter is already one, then return false. Continue.
* Time Complexity: O(n)   

# CCI Answer
* The first solution happens to be the Brute Force since you'll have to go through all of the items in the input string. But you can make small optimizations to the code.


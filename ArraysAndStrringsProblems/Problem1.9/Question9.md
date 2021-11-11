# Question 9
Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring. *erbottlewat* is a rotation of *waterbottle*. 

input: erbottlewat, waterbottle
output: true

# Brute Force
So here you see that *erbottlewat* is actually a rotation of *waterbottle*. First i thought that you could loop through each char of the waterbottle to get twice. But then the question said that you can call IsSubstring , but you can call it once.

Breaking down the problem even more we can split erbottlewat into erbottle and wat to make waterbottle. So now we have:

- s1 = erbottle
- x = erbottle
- y = wat
- s2 = waterbottle

s1 is x + y and s2 = y + x. You could loop through, but a simpler approach is to just have x+y+x+y (erbottle + wat + erbottle + wat). You see that waterbottle is a substring of xyxy or rather s1 + s1.



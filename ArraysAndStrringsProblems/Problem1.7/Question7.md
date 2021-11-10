# Question 7
Given an image represented by a NxN matrix, where each pixcel in the mimage is represented by an integer, write a method to rotate the image 90 degrees.

Can you do this in place?



# Brute Force & Analysis
- Take a column and write that as a row, the order matters so you would want to take the from the right edge of the matrix (in the example is col 5), and then write that as the first row at index 0. This solution is O(n^2^) in time and space is O(n^2^) since another list is created
- Can this be done in place? Yes, you can do this inplace by just swapping values. The time complexity is still O(n^2^). 




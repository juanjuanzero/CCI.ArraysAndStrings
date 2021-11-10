# Question 8
Write an algo such that if an element in an MxN matrix is 0, the entire row and column are set to 0;

# Brute Force and Analysis
- This seems simple at first, if you find a zero, set the whole row and column zero. But when you encounter that row and column again, you've already set it to zero. This leads to a matrix of 0s. Not good, so what you want to do is to keep track of where the zeroes are and then create a matrix from that, or just change the current matrix from that.



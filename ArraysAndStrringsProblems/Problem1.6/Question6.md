# Question 6
You have a string with repeating chars you'll need to compress it down to the char and its frequency.

_input_ -> _output_: ```aaaaaaabbbaaaacccc``` -> ``` a7b3a4c4```



# Brute Force & Analysis
* Create an empty string, if you just loop through the entire input string, as you iterate increment a counter for the frequency of the char. Check if the char is different from the next char then reset the counter and add it to the empty string.
* Time Complexity: O(n)? No. Its actually closer to O(n^2). Why?

## Cost of Concatenation
When you concatenate two strings together a new empty string is created, then the contents of string1 (sentence) and string2 (w) are copied over into the new string, char by char.

```C#
string joinWords(string[] words){
    string sentence ="";
    foreach(var w in words){
        sentence = sentence + w; //Here sentence is the previous sentence
    }
    //sentence continues to grow with each addition of w.
}
```
If we assume the code above has strings of the same length, we can say that the following 

* Iteration 0: sentence.Length = x
* Iteration 1: sentence.Length = 2x
* ...
* Iteration n: sentence.Length = nx

Or x + 2x + ... + nx. Therefore, its n(n+1)/2 ~ n^2

Here is an explanation on [Math Overflow](https://math.stackexchange.com/questions/2260/proof-1234-cdotsn-fracn-timesn12).

## Enter StringBuilder
In C# and in Java strings are immutable. In order to deal with a constantly changing string with a large amount of changes (mutations) there is a class that we can use called string builder. The only key is that we need to know how large the string needs to be so that we can appropriately size the object so as to not cause it to resize. When you resize a collection, all of the elements gets copied over into a new collection.

So the best solution will know how large string builder will need to avoid the performance hit you get from resizing.





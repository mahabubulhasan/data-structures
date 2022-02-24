# Data Structures
Purpose of this repository is to practice basic Data Structures Implementation in C#. 
Content of this repository is inspired by this youtube video 
[![](http://img.youtube.com/vi/RBSGKlAvoiM/0.jpg)](http://www.youtube.com/watch?v=RBSGKlAvoiM "")

Other relevent videos
- [Graph Algorithms for Technical Interviews - Full Course](https://www.youtube.com/watch?v=tWVWeAqZ0WU)
- [Binary Tree Algorithms for Technical Interviews - Full Course](https://www.youtube.com/watch?v=fAAZixBzIAI)
- [Recursion in Programming - Full Course](https://www.youtube.com/watch?v=IJDJ0kBx2LM)
- [Dynamic Programming - Learn to Solve Algorithmic Problems & Coding Challenges](https://www.youtube.com/watch?v=oBt53YbR9Kk)
- [10 Common Coding Interview Problems - Solved!](https://www.youtube.com/watch?v=Peq4GCPNC5c)
- [Algorithms and Data Structures Tutorial - Full Course for Beginners](https://www.youtube.com/watch?v=8hly31xKli0)
- [Linked Lists for Technical Interviews - Full Course](https://www.youtube.com/watch?v=Hj_rA0dhr2I)
- [Data Structures Easy to Advanced Course - Full Tutorial from a Google Engineer](https://www.youtube.com/watch?v=RBSGKlAvoiM)
- [Solve Coding Interview Backtracking Problems - Crash Course](https://www.youtube.com/watch?v=A80YzvNwqXA)
- [What is Binary Search?](https://www.youtube.com/watch?v=KsoUiNv1SZA)
- [Big O Notation - Full Course](https://www.youtube.com/watch?v=Mo4vesaut8g)

## What is a Data Structure
A data sturucture (DS) is a way of organizing data so that it can be used effectively.

## Abstruct Data Type
An abstruct data type (ADT) is an abstraction of a data structure which provides only the interface to which a data structure must adhere to. 
The interface does not give any specific details about how something should be implemented or in what programming language.



| Abstraction (ADT) | Implementation (DS) |
| --- | --- |
| List | Dynamic Array, Linked List |
| Queue | Linked List based Queue, Array based Queue, Stack based Queue |
| Map | Tree Map, Hash Map / Hash Table |
| List | Dynamic Array, Linked List |

# Computational Complexity Analysis

## Big-O Notation
Big-O Noation gives an upper bound of the complexity in the worst case, healping to quantify performance as the input size becomes arbitararily large. 

> Big-O only cares about the worst case.

### n - The size of the input complexities ordered in from smallest to largest:

|  X  |  Y  |
| --- | --- |
| Constant Time: | **O(1)** |
| Logarithmic Time: | **O(log(n))** |
| Linear Time: | **O(n)** |
| Linearithmic Time: | **O(nlog(n))** |
| Quadric Time: | **O(n<sup>2</sup>)** |
| Cubic Time: | **O(n<sup>3</sup>)** |
| Exponential Time: | **O(b<sup>n</sup>)** |
| Factorial Time: | **O(n!)** |


### Big-O Examples
Fidning all the subsets of a set - **O(2<sup>n</sup>)**

Fidning all permutation of a string - **O(n!)**

Sorting using mergesort - **O(nlog(n))**

Iterating over all the cells in a matrix of size n by m - **O(nm)**


# Common Data Structures

- Arrays

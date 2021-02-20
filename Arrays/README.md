# Arrays

### What is a Static Array?
A static array is a fixed length container containg n elements indexable from the range [0, n-1].

### What is meant by being 'indexable'?
This means that each slot/index in the array can be referenced with a number.

### When and where is a static Array used?
- Storing and accesssing sequential data.
- Temporarily storing objects
- Used to IO routines as buffers
- Looup tables and inverse lookup tables
- Can be used to return multiple values from a function
- Used in dynamic programming to acache answer to subproblems

## Complexity

| - | Static Array | Dynamic Array |
| --- | --- | --- |
| Access | O(1) | O(1) |
| Search | O(n) | O(n) |
| Insertion | N/A | O(n) |
| Appending | N/A | O(1) |
| Deletion | N/A | O(n) |


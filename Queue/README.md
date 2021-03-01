# Queue
 
A queue is a linear data structure which models a real world queues by having two primary operations namely enqueue and dequeue.

### When and where is a Queue used?
- Any waiting line models a queue for example a lineup at a movie theatre
- Can be used to efficiently keep track  of the *x* most recently added elements
- Web server request management where you want first come first serve
- Breadth first search (BFS) graph traversal 

## Complexity

| - | - |
| - | - |
| Enqueue | O(1) |
| Denqueue | O(1) |
| Peeking | O(1) |
| Contains | O(n) |
| Removal | O(n) |
| Is Empty | O(1) |

# Priority Queue
A priority queue is an Abstract Data Type (ADT) that operates similar to a normal queue except that each element has a certain priority. The priority of the elements in the priority queue determine the order in which elements are removed from the PQ.

**NOTE:** Priority queues only supports comparabele data, meaning that data inserted into the priority queu must be able to be ordered in some way either from least to greatest or greatest to least. This is so that we are able to assign relative priorities to each element.

## What is a Heap
A heap is a tree based Data Structure that satisfies the heap invariant (also called heap priority): If A is a parent node of B then A is ordereed with respect to B for all nodes A, B in the Heap

## When and where is a PQ used
- Used in certain implementation of Dijkstra's Shortest Path algorithm
- Anytime you need the dynamically fetch the 'next best' or 'next worst' element
- Used in Huffman coding (which is often used for lossless data compression)
- Best First Search (BFS) algorithm such as A* used PSs to continouously grab the next most promising node.
- Used by Minimum Spanning Tree (MST) algorithm

## Complexity PQ with binary heap
| - | - |
| - | - |
| Binary Heap construction | O(n) |
| Polling | O(log(n)) |
| Peeking | O(1) |
| Adding | O(log(n)) |
| Naive Removing | O(n) |
| Advanced removing help from a hash table | O(log(n)) |
| Naive contains | O(n) |
| Contains check with help of a hash table | O(1) |

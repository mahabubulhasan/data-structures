# LinkedList

A linked list a sequential list of nodes that hold data which point to other nodes also containing data.

### Uses
- Used in many List, Queue & Stack implementation
- Great for creating circular lists
- Can easily model real world objects such as trains
- Used in separate chaining, which is present certain Hashtable implementations to deal with hashing collisions
- Often used in the implementation of adjacency lists for graphs

### Terminology

**Head**: The first node in a linked list

**Tail**: The last node in a linked list

**Pointer**: Reference to another node 

**Node**: An object containing data and pointer(s)

## Singly vs Doubly Linked Lists
Singly linked list only hold a reference to the next node. In the implementation you always mainin a reference to the head to the linked list and a reference to the tail node for quick additions/removals.

With a doubly linked list each node holds a reference to the next and previous node. In the implementation you always maintain a reference to the head and the tail of the doubly linked list to do quick addtions/removals from both ends of your list.

### Singly & Doubly Linked lists Pros & Cons

| - | Pros | Cons |
| - | - | - |
| Singly LInked | Uses less memory, Simpler implementation | Cannot easily access previous elements |
| Doubly LInked | Can be traversed backewards | Takes 2x memory |


### Complexity

| - | Singly Linked| Doubly Linked |
| - | - | - |
| Search | O(n) | O(n) |
| Insert at head | O(1) | O(1) |
| Insert at tail | O(1) | O(1) |
| Remove at head | O(1) | O(1) |
| Remove at tail | O(n) | O(1) |
| Remove in middle | O(n) | O(n) |


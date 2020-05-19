# DSA
401 Data Structures and Algorithms

# Code Challenge 1: Reverse An Array

## Problem Domain
Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return a new array with elements from input array in reversed order.

## Approach and Efficiency
We set a counter to index through our new array and a for loop that iterated through our input array, and as we iterated through the for loop we increased the counter and decreased.

## Solution
[Reverse An Array Solution](assets/reverse-array.jpg)


# Code Challenge 2: Insert and Shift

## Problem Domain
Insert a value at the middle index of an array and shift the values.

## Approach and Efficiency
The approach I took has a linear time space complexity, in that it must iterate over the entire input array, and create a new array of the input array plus one, therefore making it n^2 O(n)

## Solution
[Insert and Shift Array](assets/array-shift.jpg)

# Code Challenge 3:

## Problem Domain
Perform a binary search in a 1d sorted array

## Approach and Efficiency
The approach I took has a time space complexity of O(log n).

## Solution
[Binary Search](assets/binary-search.jpg)

# Code Challenge 4: Singly Linked List
Create a singly linked list that can instantiate an empty linked list, add to the linked list, confirm if a certain value resides within the list, and can return a string with all of the linked list values.

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called toString  which takes in no arguments and returns a string representing all the values in the Linked List, formatted as: "{ a } -> { b } -> { c } -> NULL"
- Write tests to prove the following functionality:
    [X] Can successfully instantiate an empty linked list
    [X] Can properly insert into the linked list
    [X] The head property will properly point to the first node in the linked list
    [X] Can properly insert multiple nodes into the linked list
    [X] Will return true when finding a value within the linked list that exists
    [X] Will return false when searching for a value in the linked list that does not exist
    [X] Can properly return a collection of all the values that exist in the linked list

## Approach & Efficiency
I created a dynamic approach to this that is a time-space complexity of O(1).

## API

### ToString:
This method returns an empty string if the linked list is empty, thereby instantiating a new empty LinkedList. If the list is not empty, it prints out the values in the list in this format:  "{ a } -> { b } -> { c } -> NULL"
### Insert:
This method takes in an integer value as an argument and adds a new node to the list with that value as the head of the list. 
### Includes:
This method takes in an integer value as an argument and returns a boolean depending on if that value exists as a Node's value somewhere in the list. 

# Code Challenge 6: Linked List Insertions

## Problem Domain
Create the following methods:
- Adds a new node with the given value to the end of the list
- Adds a new node with the given newValue immediately before the first value node
- Adds a new node with the given newValue immediately after the first value node
- Write tests to prove the above functionalities, including when the value is the first node in the list or the last node in the list 

## Approach and Efficiency
I took both a linear and constant approach to writing the methods detailed above.

## Solution
[Linked List Insertions](assets/ll-insertions.jpg)

# Code Challenge 7: Kth From the End 

## Problem Domain
- Write a method for the Linked List class that takes in a number k as a parameter and returns the node's value that is k from the end of the linked list.

## Approach and Efficiency
The approach I used to write this method has a linear time-space complexity.

## Solution
[Kth From The End](assets/ll-from-end.jpg)

# Code Challenge 10: Stacks and Queues Implementation

## Problem Domain
- Create a stack that can
    - Push onto a stack
    - Pop off of the stack
    - Can peek the next item on the stack
    - Can instantiate an empty stack
    - Throws an exception when trying to pop or peek on an empty stack
- Create a queue that can
    - Enqueue into a queue
    - Dequeue out of a queue
    - Peek into a queue
    - Instantiate an empty queue
    - Throw an exception when trying to dequeue or peek on an empty queue

## Approach and Efficiency
The approach I took was O(1), as we do not need to traverse the whole stack or queue in order to add or remove from them.

## API
The methods publicly available to the stack are:
- Push
- Pop
- IsEmpty
- Peek
The methods publicly available to the queue are:
- Enqueue
- Dequeue
- IsEmpty
- Peek

# Code Challenge 11: Queue with Stacks

## Problem Domain
Implement a queue by using 2 stacks in a class called PseudoQueue, which should also include the ability to Enqueue and Dequeue.

## Approach and Efficiency
The approach I took to solving this code challenge was a time-efficency of O(1).

## Solution
[Queue with Stacks](assets/PseudoQueue.jpg)
# GA_BinarySearch_Ronda

What is binary search and how does it work?
- Binary search loops through an array, identifying which half of the array the search target is in. Each time, the left or right references are updated so that only the portion the target could be in is searched. When the target is at the midpoint, its index is returned.

What is the time complexity of binary search?
- O(log n), because the length of the portion being searched is halved each time the binary search loops.

When is binary search preferred over linear search?
- Binary search is preferable to linear search for large data sets, when in a sorted array.

What are the key requirements for binary search to work correctly?
- The array must be sorted beforehand. For a recursive binary search, the left and right references also need to be enetered as arguments.

Can binary search be applied to unsorted arrays? Why or why not?
- Binary search does not work on unsorted arrays, because in an unsorted array it is not possible to identify which half the search target is in based on the value of the midpoint.
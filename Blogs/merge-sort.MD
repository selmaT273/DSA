# Code Challenge 27: Merge Sort
Merge Sort implements a divide an conquer algorithm in which it recursively divides an array in two halves (subarrays) until the size becomes 1. Then, the subarrays are merged back together until the entire array has been merged. 

## Pseudocode
![Merge Sort Pseudocode](../assets/merge-sort-images/merge-sort-pseudo.png)

## Trace
Sample Array: [8, 4, 23, 42, 16, 15]

## Implementation
First, we find the midpoint of the array.
![Initial pass](../assets/merge-sort-images/merge-sort1.jpg)

Then, we continue to find the midpoints of subarrays until the subarrays only contain 1 element.
![Initial pass 2](../assets/merge-sort-images/merge-sort2.JPG)

Next, we sort all subarrays of 1 element and merge those results into subarrays of 2 elements.
![Second pass](../assets/merge-sort-images/merge-sort3.JPG)

Then, we merge the results into subarrays of 3 elements.
![Third pass](../assets/merge-sort-images/merge-sort4.JPG)

Next, we start to merge the subarrays of 3 back into a sorted array of 6 y comparing i and j to see which one is greater and then also comparing it with k, which is keeping track of our place in the array of 6.
![Fourth pass](../assets/merge-sort-images/merge-sort5.jpg)

In this pass, 8 is smaller than 15 but it is greater than 4 so we stick it into the next spot in the array of 6.
![Fifth pass](../assets/merge-sort-images/merge-sort6.jpg)

Again, we look at 23 and compare it with 15. Since 23 is greater than 15, we compare 15 with 8. Since it is greater than 8, we place it in the next spot to the right in the array of 6.
![Sixth pass](../assets/merge-sort-images/merge-sort7.jpg)

We look at 23 again and compare it now with 16. It is greater than 16 so then we compare 16 with 15. 16 is greater than 15 so we stick 16 to the right of 15.
![Seventh pass](../assets/merge-sort-images/merge-sort8.jpg)

Then we look at 23 again and compare it with 42. Since 23 is less than 42 and greater than 23, we put 23 to the right of 16. 
![Eighth pass](../assets/merge-sort-images/merge-sort9.jpg)

Since we cannot iterate through the left subarray anymore, we know that the remaining element, 42, must go to the right of 23. 
![Ninth pass](../assets/merge-sort-images/merge-sort10.jpg)




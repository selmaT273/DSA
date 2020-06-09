# Code Challenge 26: Insertion Sort
Insertion Sort is a sorting algorithm that sorts each element one at a time by comparing it with the elements that already exist in the array that it is being sorted in, and shifting those existing elements that are greater than the element to be sorted so that it can be inserted. This is repeated until the entire list is sorted. 

## Pseudocode
[Insertion Sort Pseudocode](assets/insertion-sort-images/insertion-sort-pseudo.png)

## Trace
Sample Array: [8, 4, 23, 42, 16, 15]

First we start with our unsorted array, and look at the first value as if it is already in its tentative sorted place. This value is j.
[Starting place](assets/insertion-sort-images/insertion-sort1.JPG)

Then we look at the next value to the right, which is stored as temp and compare it to j. Since temp is smaller than j, we move temp to the right of j and since it is then in the 0 index position we stop as we know there is nothing else sorted yet.
[First and second pass](assets/insertion-sort-images/insertion-sort2.JPG)

Next, we look at 23 which is now temp and compare it with j, which is 8. Temp is greater than j so we leave it in its place as we know everything to the left of j is less than j. J and Temp both move one to the right.

Then, we compare temp (42) with j (23). Since temp is more than j we leave both values in their place as we know everything to the left of 23 is smaller than 23 and thus 42 will belong on the right of 23. J and Temp move one to the right. 
[Third pass](assets/insertion-sort-images/insertion-sort3.JPG)

Next, we look at temp (16) and j (42). Temp is less than J, so we look one to the left of j and see if temp is less than that value (23). It is, so then we check again one to the left of that (8) and see if temp is less. It is greater than 8 and less than 23 so then we put temp to the left of 23.
[Fourth pass](assets/insertion-sort-images/insertion-sort4.JPG)
[Fifth image](assets/insertion-sort-images/insertion-sort5.JPG)


Finally we look at 15 and compare it with 42. We repeat the same steps as in the Fourth pass until we find where it is no longer less than j. 
[Sixth pass](assets/insertion-sort-images/insertion-sort6.JPG)
[Final image](assets/insertion-sort-images/insertion-sort7.JPG)




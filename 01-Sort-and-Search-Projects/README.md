# Insertion_Sort
## [22,27,16,2,18,6] -> Insertion Sort
### Yukarı verilen dizinin Insertion sort türüne göre aşamalarını yazınız.
* [22,27,16,2,18,6]   n
* [16,22,27,2,18,6]   n-1
* [2,16,22,27,18,6]   n-2
* [2,16,18,22,27,6]   n-3
### 2.Big-O gösterimini yazınız.
 * (n.(n+1))/2
 * (n^2+n)/2
 * O(n^2)
 ### 3.Time Complexity:
 * Average case: Aradığımız sayının ortada olması durumunda gerçekleşir. =>[22,27,16,2,18,6]
 * Worst case: Aradığımız sayının sonda olması durumunda gerçekleşir. =>[27,22,18,16,6,2]
 * Best case: Aradığımız sayının başta olması durumunda gerçekleşir. =>[2,6,16,18,22,27]
 ### 4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer?
 * Average Case
 ### [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.
 * [7,3,5,8,2,9,4,15,6]    n
 * [3,7,5,8,2,9,4,15,6]    n-1
 * [3,5,7,8,2,9,4,15,6]    n-2
 * [2,3,5,7,8,9,4,15,6]    n-3
 # Merge_Sort
 ## [16,21,11,8,12,22] -> Merge Sort
 ### Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
 ```
             16|21|11               8|12|22
            16     21|11          8|12    22
          16      21   11        8   12    22
            16     11|21          8|12    22
             11|16|21               8|12|22
                    8|11|12|16|21|22
 ```
 ### Big-O gösterimini yazınız.
 *O(nlogn)
 # Binary Search Tree
 ### [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.
 ```
              7
            /   \
          5      8
        /   \      \
       1     6      9
     /   \
    0     3
        /   \
       2     4
 ```

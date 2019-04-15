# Custom_List_Proj

CustomList<T> Overload Operator Method

Removes indices from one list that are of the same value as any indices in a second list and returns a new list of the remaining values from the first list. This method is static due to the fact that it is a method of the class, not the independent object.

C# 
CustomList;

Type Parameters
T
The type of elements in the list.

Inheritance Object → CustomList<T>

Syntax
When calling this method, set a variable equal to the minus operator.
Example: newList = listOne - listTwo

Parameters
This method takes in two parameters of type CustomList<T>. 

Return Type
This method returns a new list of type CustomList<T>.

Functionality
This method takes in two parameters, ex: listOne and listTwo. For every index within listOne it checks to see if there is an index of the same value in listTwo. If the values match, the index is not loaded into the new array, ex: newList. However, if the values do match, that value will be added to the end of newList.
Example:
CustomList<int> listOne =  new CustomList<int>() {1, 7, 4, 2};
CustomList<int> listTwo = new CustomList<int>() {3, 2, 5, 1};
newList = CustomList<int>() {7, 4}

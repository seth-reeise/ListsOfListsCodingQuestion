# Lists Of Lists Coding Question

### Given a list of lists, remove duplicates and return the list
* Only one item can be used in a list, once it is used it can not be used again in another one of the lists

This question is an example of having a list of email address for an email to be sent to with each list reprensenting as such:</br>
To:</br>
CC:</br>
BCC

* An email address should only appear once in one of the lists (IE: It can not appear in both the "To" list and the "CC" list)
* The number of lists should not change, so even if a list is empty it should be returned as an empty list

### Example input/output 

 Given the following lists:</br>
 
{ "Apple", "Banana", "Chocolate" }</br>
{ "Avocado", "Banana", "Banana", "Banana" }</br>
{ "Chocolate" }</br>
{ "Doppleganger", "Doppleganger" } 

The output should be:</br>
    
{ "Apple", "Banana", "Chocolate" },</br>
{ "Avocado" }</br>
{ }</br>
{ "Doppleganger"}

# Student-OOP
A console Application in C#

## Student Class
A Student class is used for this assignment with the following characteristics/behavior:

FirstName

LastName

Semester

StudentInfo --> this is a read-only property which returns the FirstName, LastName and Semester in this format: "LastName, FirstName - Semester". Example: "Smith, Jhon - 9"
GoToNextSemester --> increase the semester by 1. The maximum possible semester is 12, so validate the value before the increment.

## Functionality of the Menu
Displays a menu with the following options:

Add a student - ask the user for student's information and add it to the list

Find a student - ask the user for a LastName. Display all users (using StudentInfo property) that have that surname. If no users were found, display a message "User not found"

Move to next semester - Increase the semester of all students by 1

Delete a student - ask the user for a number. Remove the student at that position.

Show all students - Display all students in the list (using the StudentInfo) property

Clear the list - Delete all students. Ask the user for confirmation before clearing the list.

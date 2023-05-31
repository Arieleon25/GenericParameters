# GenericParameters

The GenericParameters project is a console application that demonstrates the use of generic type parameters in C#. It includes the implementation of the Employee class with a generic type parameter and the usage of generic lists as a property of the Employee class.

# Project Description
The GenericParameters project consists of three files: Employee.cs, Program.cs, and Utils.cs.

Employee.cs

This file contains the Employee class, which represents an employee. The Employee class is defined with a generic type parameter T. It includes a property called Things of type List<T>, which is used to store a list of items of the generic type T.

Program.cs
  
This file contains the Program class, which contains the Main method. In the Main method, the program demonstrates the usage of the Employee class with different generic type parameters. It instantiates an Employee object with the generic type parameter set to string and assigns a list of strings as the value of the Things property. It then instantiates another Employee object with the generic type parameter set to int and assigns a list of integers to the Things property.

The program also includes a loop that iterates over the Things property of each Employee object and prints the items to the console.

Utils.cs
  
This file contains utility methods used by the program, such as a method to print the items of a generic list to the console.

# Instructions
Start the console application.

The program will instantiate an Employee object with the generic type parameter set to string and assign a list of strings as the value of the Things property.

It will then instantiate another Employee object with the generic type parameter set to int and assign a list of integers to the Things property.

The program will iterate over the Things property of each Employee object and print the items to the console.

The items of the string list and the integer list will be displayed in the console.

The program will terminate.

You can rerun the program to create new instances of the Employee class with different generic type parameters and test the functionality.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to generic type parameters in C#:

Using generic type parameters in class definitions

  Creating properties with generic types

  Instantiating generic classes with different type parameters

  Working with generic lists

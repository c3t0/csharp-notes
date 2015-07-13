## Variable scope

Once the code block is executed all variables declared in that block are disposed of by the run time.

Also applies to variables that are reference to an object.

When the scope of execution at run time no longer involves the code block the variable will no longer be available

### Field
When you declare a variable as a child to the class itself you create a it a *field*

Fields are similar to properties but the subtle difference does not have getters and setters

remember the static since we plan to use it in the body of the static void main.

Static memer is accessible 
- accross all instances of the class and 
- all of the methods, properties and fields that it utilizes have to be static as well

##  Accessibility Modifiers

They are used to implement encapsulation

All the functionality of a class should be encapsulated behind the public properties and public methods.

Private methods and properties fields should not be exposed to the user of the class since they will only be sued in the internal functionality of the class.

### Public 

Should start with a capital letter

any method or property that is exposed to the user of the class

### Private

should be camel case starting with a lower case letter

any other method inside the same class but not outside of the class

### Protected

Only exposed to classes derived from the class.

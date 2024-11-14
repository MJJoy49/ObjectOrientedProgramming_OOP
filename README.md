# Object Oriented Programming (OOP)

**_The basic OOP concept has 3 type_**

- Encapsulation
- Abstraction
- Inheritance
- Polymorphism


### **Encapsulation**

Encapsulation is defined as wrapping up data and information under a single unit to manipulate them  


<img src="Readme_Imgs/Encapsulation.jpg" alt="Encapsulation_img" width="500" height="350">

In this example, the age attribute is private, and we manipulate it using the public property Age, ensuring that only valid values can be assigned to age.



### **Abstraction**

Data Abstraction refers to providing only essential information to the outside world and hiding the background details, i.e., representing the needed information in the program without presenting the details.
#### Example: *public*, *private*, *protected*

<img src="Readme_Imgs/Abstraction.jpg" alt="Abstraction_img" width="500">

Explanation:
- Data Abstraction is achieved by hiding the internal details of the Car class (such as the model and engineType fields) from the outside world.
- The user interacts with the car through the SetCarDetails and DisplayCarDetails methods, which are the essential operations the user needs to know about, without needing to access or understand the internal fields directly.



### **Polymorphism**

The word polymorphism means having many forms. Typically, polymorphism occurs when there is a hierarchy of classes, and they are related by inheritance.
#### Example: *Function overloading*, *Function overriding*

<img src="Readme_Imgs/Polymorphism_P1.jpg" alt="Polymorphism_img" width="500">
<img src="Readme_Imgs/Polymorphism_P2.jpg" alt="Polymorphism_img" width="500">
<img src="Readme_Imgs/Polymorphism_P3.jpg" alt="Polymorphism_img" width="500">

Explanation:
- The Speak method is defined in the Animal base class as a virtual method.
- Dog and Cat classes override this method to provide their own implementation.
- In the Main method, the same method Speak is called on both myDog and myCat, but the output differs based on the actual object type, demonstrating polymorphism.
This is polymorphism in action: the same method name behaves differently depending on the object calling it.
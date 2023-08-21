// ---------------------Week1-Part1-----------------------
// namespace indicates the name of our project/app. folder 
// to organize code at the highest logical level
namespace HelloWorld; 

/*
    - A class is a sublevel of namespace; 
    - A namespace contains one or more classes
    - A class is container which holds data and code to do a particular job
*/
class Program
{
    // Main method is the entrance of your program. 
    // Main method runs code from top to the bottom line by line 
    // A method is a block of code that performs a specific task
    static void Main(string[] args)
    {
        // Console.WriteLine(input_words): it is a method pre-defined in C#
        // to print words on the Console/Terminal
        Console.WriteLine("Hello, World!");

        // Practice 1: Print Out Your Name 
        Console.WriteLine("Carl Zhang");

        /* 
        Multi-line comments (a pair of slash and asterisk):
        Some long comment text to explain functionality code block
        */
        
        // Single-line comment (two slashes): 
        // Put single-line comment above the code line
        
        // tips: we can "commenting out" some of the code when debugging (testing) our program
        // select the code we want to comment out
        // press Ctrl+/  (Command+/ in macOS) to comment and uncomment code

        // Escape sequences
        // \t for a tab space.
        // \" for a double-quote.
        // \\ for a backslash.
        // \n for a new line.

        Console.Write("Hello\tWorld\nHello\tWT");
        Console.WriteLine("\\\\\\\\");
        Console.WriteLine("\"\"");

        // ---------------------Week1-Part2-----------------------
         //create age variable
        int age = 26;
        int Age = 25;  //Assign integer 25 to variable Age.
        var _age = 20;
        string first_name = "Alice";  //Assign string “Alice” to variable first_name.
        string studentFirstName= "Alice";
        string StudentFirstName= "Alice";
        string student_first_name= "Alice";

        // Assign variable to variable:
        int a = 10;
        int b = a;
        Console.WriteLine("Value of b: " +b);

        // Overwrite value of a variable
        int m = 10;
        int n = m+10;
        n = 100;
        Console.WriteLine("Value of n: "+n);


        // Example:
        int x = 10;
        int y = x;
        x = 20;
        Console.WriteLine("Value of y: "+y);

    // Formatted String
        int my_age = 29;
        string my_name = "Alice";
        // string concatenation is the operation of joining strings end-to-end.
        Console.WriteLine("My name is " + my_name +", "+"I am "+my_age+ " years old");
        // string formatting
        Console.WriteLine("My name is {0}, I am {1} years old.", my_name, my_age);
        // string interpolation
        Console.WriteLine($"My name is {my_name}, I am {my_age} years old.");   

        // Data type practice:
        // declare an int variable called Year and initialize it to 2020 
        int year = 2020;

        // declare a string variable called Major and initialize it to “CIS”
        string major = "CIS";
        // declare a double variable called Weight and initialize it to 73.5
        double weight = 80.5555;
        // declare a char variable called letter_grade and initialize it to ‘A’
        char grade= 'A';
        // declare a Boolean variable called is_online and initialize it to true
        bool is_online = false;


        // Practice: Define two variables: 
        // we have defined a,b in previous code, so here we use a1,b1 as variables
        int a1 = 10;
        int b1 = 3;
        double c1 = 2.4;
        
        // Calculate: a/b, a/c, a*b, a*c, a-c and check the data type of these results.
        Console.WriteLine($"a = {a1}, b = {b1}, c = {c1}");
        Console.WriteLine($"a/b= {a1/b1}, Data type:{(a1/b1).GetType().Name}");
        Console.WriteLine($"a/c= {a1/c1}, Data type:{(a1/c1).GetType().Name}");
        Console.WriteLine($"a*b= {a1*b1}, Data type:{(a1*b1).GetType().Name}");
        Console.WriteLine($"a*c= {a1*c1}, Data type:{(a1*c1).GetType().Name}");
        Console.WriteLine($"a-b= {a1-b1}, Data type:{(a1-b1).GetType().Name}");
        Console.WriteLine($"a%b= {a1%b1}, Data type:{(a1%b1).GetType().Name}");


        // Increment/Decrement Operator
        int num1 = 10;
        Console.WriteLine($"num1 = {num1}");
        num1++; // num1 = 10+1 =11
        Console.WriteLine($"after num1++, num1 = {num1}");
        ++num1; // num1 = 11+1 =12
        Console.WriteLine($"after ++num1, num1 = {num1}");

        int num2 = num1--;  // num2 = num1 = 12; num1 = num1-1=12-1 =11
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");

        num2 = --num1;  // num1 = num1-1=11-1 =10, num2 = num1 = 10; 
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");
    }
}

/* 
    Multi-line comments (a pair of slash and asterisk):
    Some long comment text to explain functionality code block
*/

// Single-line comment (two slashes): 
// Put single-line comment above the code line

// tips: we can "commenting out" some of the code when debugging (testing) our program
// select the code we want to comment out
// press Ctrl+/  (Command+/ in macOS) to comment and uncomment code


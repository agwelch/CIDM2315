
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------Week4 Lecture1---------");
        // Review Exercise
        // Q1 1. Using a loop, ask user to input 3 integers and then print total of 3 given integers.
        string str_num;
        int int_num;
        int total = 0;
        for(int i =1; i<4; i++){
            Console.WriteLine($"Please input integer {i}: ");
            str_num = Console.ReadLine();
            int_num = Convert.ToInt16(str_num);
            total = total + int_num;
        }
        Console.WriteLine($"The total is: {total}");'
            
        // Q2. Write C# code that allows a user to login with a maximum of 3 attempts
        string correctUsername = "alice";
        string correctPassword = "alice123";
        int maxAttempts = 3;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                Console.WriteLine($"Login Failed. You have {maxAttempts - attempt} attempt(s) left.");
            }
        }


        // nested for loop
        for(int row = 0; row<3; row++){
            for(int col = 0; col <3; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine("");
            }

        // More Nested loop Example
        Console.WriteLine("------------------");
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                Console.Write(col);
            }
            Console.WriteLine("");
        }

        Console.WriteLine("------------------");
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        }

        Console.WriteLine("------------------");
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                if(row>=col) // no {} if only one code line
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
        
        
        Console.WriteLine("------------------");
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                if(row<=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }

        // find max value from given two numbers
        int num1, num2, max_num;
        num1 = 10; 
        num2 = 20;
        // if-else statement
        if(num1 > num2){
            max_num = num1;
        }
        else{
            max_num = num2;
        }
        Console.WriteLine($"The max value is: {max_num}");

        // Conditional operator
        max_num = (num1 > num2) ? num1 : num2;
        Console.WriteLine($"The max value is: {max_num}");



        Console.WriteLine("---------Week4 Lecture2---------");
        // put code in the main method
        int stu_id1 = 101;
        string stu_name1 = "Alice";
        Console.WriteLine($"Welcome to WT Student: {stu_id1}! Your name is: {stu_name1}");
        int stu_id2 = 102; string stu_name2 = "Bob";
        int stu_id3 = 103; string stu_name3 = "Cathy";
        int stu_id4 = 104; string stu_name4 = "David";
        int stu_id5 = 105; string stu_name5 = "Ella";
        //Call  User defined Method
        Console.WriteLine("-----Print information with method-----");
        WelcomeMessage(stu_id1, stu_name1);
        WelcomeMessage(stu_id2, stu_name2);
        WelcomeMessage(stu_id3, stu_name3);
        WelcomeMessage(stu_id4, stu_name4);
        WelcomeMessage(stu_id5, stu_name5);

         Console.WriteLine("----------\n\n");
        // call PrintWords method
        Console.WriteLine("-----PrintWords method-----");
        PrintWords();
        Console.WriteLine("----------\n\n");

        Console.WriteLine("-----Methods with Return Values-----");
        // Call method ThreeSum method
        int returned_sum = ThreeSum(1,2,3);
        Console.WriteLine($"Returned Sum is: {returned_sum}");
        // Call method ThreeAvg
        double returned_avg = ThreeAvg(3,3,4);
        Console.WriteLine($"Returned Average is:{returned_avg}");
        Console.WriteLine("----------\n\n");

        // call Exercise1
        Console.WriteLine("-----Exercise1-----");
        evenOdd(5);
        Console.WriteLine("----------\n\n");


        Console.WriteLine("-----PrintNames method-----");
        // Passing arguments: assign values to parameters by default parameters order
        PrintNames("Alice", "Smith");
        // Passing arguments: assign variables to parameters by default parameters order
        string fName = "Alice";
        string lName = "Smith";
        PrintNames(fName,lName);
        // Passing arguments: assign variables with parameter names
        PrintNames(firstName:fName,lastName:lName);

        // call method with two parameter values
        int two_grade_sum = GradeSum(english:60, math:90);
        Console.WriteLine("Sum Grade of two classes: " + two_grade_sum);
        // call method with three parameter values	
        int three_grade_sum = GradeSum(english:60, math:90, java:100);
        Console.WriteLine("Sum Grade of three classes: " + three_grade_sum);

        // call Exercise2
        double avg_three = ThreeNumAvg(A:1,B:5,C:6);
        double avg_two = ThreeNumAvg(A:1,C:6);
        Console.WriteLine($"Average of three given values: {avg_three}");
        Console.WriteLine($"Average of two given values: {avg_two}");

    }

   ///////////----UDF: Outside Main method------///////////
    // user-defined Method to print welcome message
    static void WelcomeMessage(int stu_id, string stu_name){
        Console.WriteLine($"Welcome to WT Student: {stu_id}! Your name is: {stu_name}");
    }
    static void PrintWords(){
        Console.WriteLine("Sample method without inputs and outputs values");
    }


    static void PrintNames(string firstName, string lastName)
    {
        Console.WriteLine($"First Name: {firstName}; Last Name: {lastName}");
    }

    // method having parameters and return integer values
    static int ThreeSum(int a, int b, int c){
    int total = a+b+c;
    return total; // return is the end line of the method;
    Console.WriteLine("End!"); // this line can't be printed out
    }
    
    // method having parameters and return double values
    static double ThreeAvg(int a, int b, int c){
    double avg = (a+b+c)/3.0;
    return avg; 
    }
    // Exercise1: Write a method with an int parameter to check if the given integer is even or odd use 5 to test your method
    static void evenOdd(int num){
        if(num%2==0){
            Console.WriteLine($"{num} is even");
        }
        else{
            Console.WriteLine($"{num} is odd");
        }
    }

    
    // method with parameter default values
    static int GradeSum(int english, int math, int java = 0){
        return english+math+java;
    }


    // Exercise 2:Write a double method called ThreeNumAvg() with three parameters: double A, double B and double C;
    // parameter B has a default value 3;
    // Call this method in Main() twice with following parameter values
    // A = 1, B = 5, C=6
    // A = 1, C = 5
    // Print return values in Main() method.

    static double ThreeNumAvg(double A, double C, double B = 3){
        double result = (A+B+C)/3;
        return result;
    }

}

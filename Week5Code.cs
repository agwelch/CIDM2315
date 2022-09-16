namespace Week5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------Three ways to passing arguments----------------");

        // Passing arguments: assign values to parameters by default parameters order
        PrintNames("Alice", "Smith");

        // Passing arguments: assign variables to parameters by default parameters order
        string fName = "Alice";
        string lName = "Smith";
        PrintNames(fName,lName);

        // Passing arguments: assign variables with parameter names
        PrintNames(firstName:fName,lastName:lName);

        Console.WriteLine("-----------Default Parameters----------------");

        // call with two parameter values
        int two_grade_sum = GradeSum(english:60, math:90);
        Console.WriteLine("Sum Grade of two classes: " + two_grade_sum);
        // call with three parameter values
        int three_grade_sum = GradeSum(english:60, math:90, java:100);
        Console.WriteLine($"Sum Grade of three classes: {three_grade_sum}");
        
        // call Exercise 1 methods with different number of arguments
        double avg1 = ThreeNumAvg(A:1.5, B:5.5, C:6.5);
        Console.WriteLine($"Average of three given Values: {avg1}");
        double avg2 = ThreeNumAvg(A:1.5, C:5.5);
        Console.WriteLine($"Average of two given Values: {avg2}");

        Console.WriteLine("-----------ref Keyword----------------");
        // balance in a bank account for user Alice
        int balanceAlice = 1000;
        Console.WriteLine($"The initial Account Balance: {balanceAlice}");
        // save 500 to the account then take out 300 from the account
        Deposit(accountBalance:balanceAlice, amount:500);
        Withdraw(accountBalance:balanceAlice, amount: 300);
        Console.WriteLine($"Account Balance for Alice: {balanceAlice}");

        // ref keyword
        int balanceBob = 1000;
        Console.WriteLine($"The initial Account Balance: {balanceBob}");
        // save 500 to the account then take out 300 from the account
        refDeposit(accountBalance:ref balanceBob, amount:500);
        refWithdraw(accountBalance:ref balanceBob, amount: 300);
        Console.WriteLine($"Account Balance for Bob: {balanceBob}");

        Console.WriteLine("-----------out Keyword----------------");
        // call GetNumbers to get values
        int inputNum1, inputNum2;
        GetNumbers(out inputNum1, out inputNum2);
        Console.WriteLine($"Integers from out parameters of GetNumbers methods:{inputNum1} ; {inputNum2}");


        Console.WriteLine("-----------Method overloading----------------");

        // call method overloading example
        Print(CourseName:"Math", PointGrade:98.5);
        Print(StuName: "Alice", StuID: 12345);



        Console.WriteLine("\n-----------Methods call Methods----------------");
        // call methods 
        string first_name = "Alice";
        string last_name = "Smith";
        bool driver_license = false;
        double history = 90;
        double math = 100;
        StudentSummary(first_name,last_name,driver_license, history, math);
    }

    //---------------Part1---------------

    // Passing Arguments When Call Methods
    static void PrintNames(string firstName, string lastName)
    {
    Console.WriteLine($"First Name: {firstName}; Last Name: {lastName}");
    }

    //Optional Parameters 
    static int GradeSum(int english, int math , int java=0){
	    return english+math+java;
    }

    //Exercise 1
    static double ThreeNumAvg(double A, double C, double B =3.5){
        return (A+B+C)/3;
    }

    // save money to bankAccount
    static void Deposit(int accountBalance, int amount){
        accountBalance =accountBalance+amount;
    }
    // take out money from bankAccount
    static void Withdraw(int accountBalance, int amount){
        accountBalance = accountBalance - amount;
    }

    
    static void refDeposit(ref int accountBalance, int amount){
        accountBalance =accountBalance+amount;
    }
    // take out money from bankAccount with ref parameter
    static void refWithdraw(ref int accountBalance, int amount){
        accountBalance = accountBalance - amount;
    }
    
    // define out parameters to transfer data out of the method
    static void GetNumbers(out int num1, out int num2){
        Console.WriteLine("Please input two integers: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        num2 = Convert.ToInt16(Console.ReadLine());
    }

    //---------------Part2---------------

   // Method overloading
    static void Print(string CourseName, double PointGrade){
        Console.WriteLine($"The grade of {CourseName} is: {PointGrade}");
    }
    static void Print(string StuName, int StuID){
        Console.WriteLine($"The Student ID of {StuName} is {StuID}");
    }

    // Methods call Methods
    static void StuInfo(string FirstName, string LastName, bool DriverLicense){
        Console.WriteLine($"Student's full name: {FirstName} {LastName}");
        Console.WriteLine($"Student has driver license: {DriverLicense}");
    }
    static double TotalGrade(double Course1=0, double Course2=0, double Course3=0){
        double sum = Course1+Course2+Course3;
        return sum;
    }
    static void StudentSummary(string _FirstName, string _LastName, bool _DriverLicense, double _Course1=0,double _Course2=0, double _Course3=0){
        StuInfo(_FirstName,_LastName,_DriverLicense);
        double total_grade = TotalGrade(_Course1,_Course2,_Course3);
        Console.WriteLine($"Student's total grade: {total_grade} points");
    }
}

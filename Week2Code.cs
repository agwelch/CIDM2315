namespace Week2;
class Program
{
    static void Main(string[] args)
    {
        // Get User Input: Console.ReadLine() 
        //get string input from keyboard
        Console.WriteLine("Please input your name: ");
        string user_name = Console.ReadLine();
        Console.WriteLine("Please input your age: ");
        string user_age = Console.ReadLine();
        // convert user_age from string to int
        int age_int = Convert.ToInt16(user_age);
        int birth_year = 2021 - age_int;
        Console.WriteLine($"{user_name} was born in {birth_year}");

        // Datatype Conversion
        double double_num = 90.2123124155661234567;
        float float_num = (float) double_num;
        int int_num = (int) double_num;
        char char_num = (char) double_num;
        Console.WriteLine($"double_num: {double_num}");
        Console.WriteLine($"float_num: {float_num}");
        Console.WriteLine($"int_num: {int_num}");
        Console.WriteLine($"char_num: {char_num}");

        // compare values
        int num1 = 10;
        int num2 = 20;
        Console.WriteLine($"num1>num2: {num1>num2}");

        int num3 = 10;
        int num4 = 20;
        Console.WriteLine($"num3!=num4: {num3 != num4}");

        int a = 5;
        int b = 10;
        Console.WriteLine($"a= {a}, b= {b}");
        Console.WriteLine($"a>b: {a>b}");
        Console.WriteLine($"a<b: {a<b}");
        Console.WriteLine($"a==b: {a==b}");
        Console.WriteLine($"a!=b: {a!=b}");
        Console.WriteLine($"true:{true}");
        Console.WriteLine($"false:{false}");

        // if statement
        int x = 3, y =10;
        if(x<y){
        Console.WriteLine($"x = {x}, y = {y}");
        Console.WriteLine($"x<y: {x<y}");
        }
        Console.WriteLine("Code below if statement");

        //if-else statement
        int c = 3, d =10;
        Console.WriteLine($"c = {c}, d = {d}");
        // if-else statement
        if(c >= d) {
        Console.WriteLine($"if-block, c >= d: {c >= d}");
        }
        else{
        Console.WriteLine($"else-block, c >= d: {c >= d}");
        }
        Console.WriteLine("Code below if-else statement");

        // Exercise1
        Console.WriteLine("Please input an integer: ");
        string num = Console.ReadLine();
        // convert num from string to int
        int num_int = Convert.ToInt16(num);
        // Positive or Negative
        if(num_int>=0){
            Console.WriteLine($"{num_int} is Positive");
        }
        else{
            Console.WriteLine($"{num_int} is Negative");
        }
        // Even or Odd
        if(num_int%2==0){
            Console.WriteLine($"{num_int} is Even");
        }
        else{
            Console.WriteLine($"{num_int} is Odd");
        }

        // if else-if statement
        Console.WriteLine("Please input a point grade: ");
        string point = Console.ReadLine();
        int point_int = Convert.ToInt16(point);
        if(point_int>=90){
        Console.WriteLine("Letter Grade: A");
        }
        else if (point_int>=80){ // 80<=point<90
        Console.WriteLine("Letter Grade: B");
        }
        else if (point_int>=70){ // 70<=point<80
        Console.WriteLine("Letter Grade: C");
        }
        else if (point_int>=60){ // 60<=point<70
        Console.WriteLine("Letter Grade: D");
        }
        else{ // point<60
        Console.WriteLine("Letter Grade: F");
        }

        // switch statement
        int day = 6;
        switch (day) 
        {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            Console.WriteLine("Hello Weekend");
            break;
        case 7:
            Console.WriteLine("Sunday");
            Console.WriteLine("Hello Weekend");
            break;
         
        // optional
        default:
            Console.WriteLine("Invalid day of week");
            break;
        }

        // //// if else-if statement
        Console.WriteLine("Please input a point grade: ");
        string points = Console.ReadLine();
        int point_ints = Convert.ToInt16(point);
        if(point_ints>=90){
            Console.WriteLine("Letter Grade: A");
        }
        else if (point_ints>=80){ // 80<=point<90
            Console.WriteLine("Letter Grade: B");
        }
        else if (point_ints>=70){ // 70<=point<80
            Console.WriteLine("Letter Grade: C");
        }
        else if (point_ints>=60){ // 60<=point<70
            Console.WriteLine("Letter Grade: D");
        }
        else{   // point<60
            Console.WriteLine("Letter Grade: F");
        }

        // Exercise  2
        Console.WriteLine("Please input an integer X: ");
        string X_string = Console.ReadLine();
        int X = Convert.ToInt16(X_string);
        if(X==0){
            Console.WriteLine("x is Zero");
        }
        else if(X>0){
            Console.WriteLine("x is Positive");
        }
        else{ // X<0
            Console.WriteLine("x is Negative");
        }

        // //  -----------Part 2
        // nested if-else statement
        int n1 = 10, n2 = 70, n3 = 30;
        if(n1>n2){
            if(n1>n3){
                Console.WriteLine("The largest num: n1");
            }
            else{//n1<=n3
                Console.WriteLine("The largest num: n3");
            }
        }
        else{ //n2>=n1
            if(n2>n3){
                Console.WriteLine("The largest num: n2");
            }
            else{//n3>=n2
                Console.WriteLine("The largest num: n3");
            }
        }

        // logic operater: and, 
        // if you are over 18 and have driver license
        // you can drive
        int age = 20;
        bool driver_license = true;
        if( (age>=18) && (driver_license==true) ){
            Console.WriteLine("You can drive");
        }

        // logic operater: or 
        // Apply Ph.D. with B.S. or M.S. 
        string degree = "MS";
        if( degree == "MS" || degree =="BS"){
            Console.WriteLine("You can apply for Ph.D.");
        }

        // // Exercise 3
        // // hardcode username and password
        string username = "alice";
        string password = "alice123";

        Console.WriteLine("Please input username: ");
        string input_username =  Console.ReadLine();

        Console.WriteLine("Please input password: ");
        string input_password =  Console.ReadLine();

        if(username==input_username && password==input_password){
            Console.WriteLine("Log in successfully!");
        }
        else{
            Console.WriteLine("Please check your username and password");
        }
    }
    
}


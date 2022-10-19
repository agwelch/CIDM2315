 namespace Week10;
 using System.Linq;
 class Program
 {
    static void Main(string[] args)
    {
        int[] int_1d_array = {1,2,3,4,5};
        int[,] int_2d_array = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
        int[][] int_jagged_array = {
                new int[]{1,2,3},
                new int[]{4,5},
                new int[]{6,7,8,9}
            };
        ArrayLength(int_1d_array, int_2d_array,int_jagged_array);
        ArrayRank(int_1d_array, int_2d_array,int_jagged_array);
        MaxMinSum(int_1d_array);

        int[] int_1d_array2 = {11,2,33,4,45};
        string[] name = {"David","Bob","Cathy","Alice"};
        ArraySort(int_1d_array2, name);
    
 

        string[] car = {"Volvo","BMW","Ford", "Mazda"};
        Console.WriteLine($"The index of BMW in array car is: {Array.IndexOf(car, "BMW")}");

        int[,] int_2d_array2 = {
            {1,2,3,4},
            {4,5,6,8}
        };
        Console.WriteLine($"The number of row: {int_2d_array2.GetLength(0)}");
        Console.WriteLine($"The number of col: {int_2d_array2.GetLength(1)}");
        for(int row = 0; row<int_2d_array2.GetLength(0);row++){
            for(int col=0; col<int_2d_array2.GetLength(1); col++){
            Console.Write(int_2d_array2[row, col]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n--------Exercise1----------");
        int[] int_arr3 = {1,23,44,552,34,88,91,256,22,31,45};

        Exercise1(int_arr3);


        // String: property and methods
         // a string is a sequence of characters (char value)
        string str = "This is a string consisting of characters (char values)";
        Console.WriteLine($"Print first char value: {str[0]}, its datatype is: {str[0].GetType()}");

        // str.Length: returns the length of the string.
        Console.WriteLine($"str length: {str.Length}");
        // str.IndexOf(value) returns the index of the first occurrence of the value within the string.
        Console.WriteLine($"The index of \"is\": {str.IndexOf("is")}");
        // str.Insert(index, value) inserts the value into the string starting from the specified index.
        string insert_str = str.Insert(0, "Hello!");
        Console.WriteLine("String after Insert: "+ insert_str);
        // str.Remove(index) removes all characters in the string from the specified index.
        string remove_str = str.Remove(str.IndexOf("(char"));
        Console.WriteLine("String after Remove: "+ remove_str);
        // str.Replace(old_value, new_value) replaces the specified value in the string.
        string replace_str = str.Replace("characters", "CHARACTERS" );
        Console.WriteLine("String after Replace: "+replace_str);
        // Substring(index, length) returns a substring of the specified length, starting from the specified index. 
        // If length is not specified, the operation continues to the end of the string.
        string sub_str = str.Substring(str.IndexOf("(char"),5);
        Console.WriteLine("Substring: "+sub_str);
        // Contains(value) returns true if the string contains the specified value.
        bool containsChar = str.Contains("char");
        Console.WriteLine("Contains char: "+ containsChar);


        
        // create an empty Array then assign values
        string[] name_arr1 = new string[3];
        name_arr1[0] = "Alice";
        name_arr1[1] = "Bob";
        name_arr1[2] = "Cathy";
        // create an array with initial values
        string[] name_arr2 = new string[]{"Alice","Bob","Cathy"};

        // create an empty List then assign values
        // We can also limit the size of a list by assign integer within ();
        List<string> name_list1 = new List<string>();
        name_list1.Add("Alice");
        name_list1.Add("Bob");
        name_list1.Add("Cathy");
        name_list1.Add("David");
        name_list1.Add(null); //empty value

        // create a List with initial values
        List<string> name_list2 = new List<string>(){"Alice","Bob","Cathy","David",null};
        
        //access element with index
        Console.WriteLine("\n----Access element with index----");
        Console.WriteLine($"Access first element in name_arr1: {name_arr1[0]}");
        Console.WriteLine($"Access first element in name_list1: {name_list1[0]}");

        // iterate Array:name_arr1
        Console.WriteLine("\n----Iterate Array with foreach----");
        foreach(var name1 in name_arr1){
            Console.Write(name1 +" ");
        }
        // iterate List:name_list1
        Console.WriteLine("\n\n----Iterate List with foreach----");
        foreach(var name2 in name_list1){
            Console.Write(name2 +" ");
        }

        Console.WriteLine("\n\n----Get number of elements----");
        // get number of elements
        Console.WriteLine($"Number of elements in name_arr1: {name_arr1.Length}");
        Console.WriteLine($"Number of elements in name_list1: {name_list1.Count}");


        // List methods
        List<string> weekday_list = new List<string>(){"Monday","Tuesday","Wednesday","Sunday"};
        // Add element
        weekday_list.Add("Friday");
        // Remove element
        weekday_list.Remove("Sunday");
        // Insert element with specified index 
        weekday_list.Insert(3,"Thursday");
        // print all elements
        Console.WriteLine("----elements in weekday_list----");
        foreach(var day in weekday_list){
            Console.Write(day +" ");
        }
        // Check if contains a value
        Console.WriteLine($"\nContains Wednesday: {weekday_list.Contains("Wednesday")}");

        Console.WriteLine("\n----Dictionary: Key-Value Pairs----");
        // Dictionary: a collection of key-value paris
        // Keys must be unique
        // create a dictionary contains id-name pairs; 
        // int id is the key, and string name is value
        Dictionary<int, string> stu_info = new Dictionary<int,string>();
        // Add key-value pairs
        stu_info.Add(111,"Alice");
        stu_info.Add(222,"Bob");
        stu_info.Add(333,"David");
        // iterate all pairs with foreach
        Console.WriteLine("\n----Iterate Key-Value Pairs----");
        foreach(var stu in stu_info){
            Console.WriteLine($"Student ID: {stu.Key}, Name: {stu.Value}");
        }
        // access a value with its key
        Console.WriteLine($"The name of ID 111: {stu_info[111]}");
        // check number of pairs in the dictionary
        Console.WriteLine($"Number of pairs: {stu_info.Count}");

        // remove the pair if the key exists
        if(stu_info.ContainsKey(333)){  // dict_name.ContainsKey(key_value)
            stu_info.Remove(333);
        }

        Console.WriteLine("\n----Iterate Key-Value Pairs Again----");
        foreach(var stu in stu_info){
            Console.WriteLine($"Student ID: {stu.Key}, Name: {stu.Value}");
        }

        // list of objects
        Console.WriteLine("\n\n----List of Student Objects----");

        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        
        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }
    }
   //  Array Length Property
    static void ArrayLength(int[] int_1d_array, int[,] int_2d_array, int[][] int_jagged_array){
        Console.WriteLine($"The length of int_1d_array is: {int_1d_array.Length}");
        Console.WriteLine("Iterate values in an array based on array length in a for loop");
        for(int idx = 0; idx<int_1d_array.Length; idx++){
            Console.WriteLine($"{int_1d_array[idx]}");
        }
        Console.WriteLine($"The length of int_2d_array is: {int_2d_array.Length}");
        Console.WriteLine($"The length of int_jagged_array is: {int_jagged_array.Length}");
    }
    //   Array Rank Property
    static void ArrayRank(int[] int_1d_array, int[,] int_2d_array, int[][] int_jagged_array){
        Console.WriteLine($"The dimension of int_1d_array is: {int_1d_array.Rank}");
        Console.WriteLine($"The dimension of int_2d_array is: {int_2d_array.Rank}");
        Console.WriteLine($"The dimension of int_jagged_array is: {int_jagged_array.Rank}");
    }

    //   Linq: add data querying capabilities to .NET languages
    //   Max(), Min(), Sum(), Average() only work on 1d-array
    static void MaxMinSum(int[] int_1d_array){
        Console.WriteLine($"The Max value of int_1d_array is: {int_1d_array.Max()}");
        Console.WriteLine($"The Min value of int_1d_array is: {int_1d_array.Min()}");
        Console.WriteLine($"The Sum value of int_1d_array is: {int_1d_array.Sum()}");
        Console.WriteLine($"The Avg value of int_1d_array is: {int_1d_array.Average()}");
    }

    //   sort array
    static void ArraySort(int[] int_1d_array, string[] name){
        Console.WriteLine("Original Order of int_1d_array: ");
        foreach(var val in int_1d_array){
            Console.Write(val+ " ");
        }
        Array.Sort(int_1d_array);

        Console.WriteLine("\nSorted int_1d_array: ");
        foreach(var val in int_1d_array){
            Console.Write(val+ " ");
        }
    
        Console.WriteLine("\n------------------");
        Console.WriteLine("Original Order of name array: ");
        foreach(var val in name){
            Console.Write(val+ " ");
        }
        Array.Sort(name);
        Console.WriteLine("\nSorted name array: ");
        foreach(var val in name){
            Console.Write(val+ " ");
        }
    }


    static void Exercise1(int[] arr){
        Console.WriteLine($"The lenght of array: {arr.Length}");
        Console.WriteLine($"The dimension of array: {arr.Rank}");
        Console.WriteLine($"Max value: {arr.Max()}");
        Console.WriteLine($"Min value: {arr.Min()}");
        Console.WriteLine($"Sum value: {arr.Sum()}");
        Array.Sort(arr);
        Console.WriteLine("The sorted array: ");
        foreach(int val in arr){
            Console.Write(val +" ");
        }
        Console.WriteLine($"\nThe index of 256 in sorted array: {Array.IndexOf(arr, 256)} ");
    }
    
 }




class Student{
    public static List<Student> student_list = new List<Student>();
    public int stuID { get; set; }
    public string stuName { get; set; }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {stuID}, Student Name: {stuName}");
    }
    public Student(int inputID, string inputName){
        stuID = inputID;
        stuName = inputName;
        student_list.Add(this);
    }
}

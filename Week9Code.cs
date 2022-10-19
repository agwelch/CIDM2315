namespace Week9;
class Program
{

    public static void Main(string[] args) {
        // P4
        // int array with 5 elements
        int[] int_array = new int[5]; 
        Console.WriteLine(int_array);
        // double array with 6 elements
        double[] double_array = new double[6];
        Console.WriteLine(double_array);
        // string array with 10 elements
        string[] string_array = new string[10];
        Console.WriteLine(string_array);
        // bool array with 3 elements
        bool[] bool_array = new bool[3];
        Console.WriteLine(bool_array);

        // P5
        Console.WriteLine("\n--------Page5----------");
        // provide initial values to the array by using curly brackets
        string[] name_arr1 = new string[3] {"Alice", "Bob", "Cathy"};
        double[] price_arr1 = new double[4] {3.6, 9.8, 6.4, 5.9};
        // omit the array size  
        string[] name_arr2 = new string[] {"Alice", "Bob", "Cathy"};
        double[] price_arr2 = new double[] {3.6, 9.8, 6.4, 5.9};
        // even omit the new operator.
        string[ ] name_arr3 = {"John", "Mary", "Jessica"};
        double[ ] price_arr3 = {3.6, 9.8, 6.4, 5.9};

        int[ ] int_arr = {10,15,20,25,30};

        // P7
        Console.WriteLine("\n--------Page7----------");
        for(int idx = 0;idx<5;idx++){
            Console.WriteLine(int_arr[idx]);
        }
        Console.WriteLine("\n--------double a array----------");
        int[] int_arr2 = new int[5];
        for(int idx = 0;idx<5;idx++){
            int_arr2[idx] = int_arr[idx]*2;
        }
        for(int idx = 0;idx<5;idx++){
            Console.WriteLine(int_arr2[idx]);
        }
        Console.WriteLine("\n---------foreach---------");
        foreach(int val in int_arr2){
            Console.WriteLine(val);
        }
        Console.WriteLine("\n------------------");


        // Exercise 1
        Console.WriteLine("\n--------Exercise1----------");
        // inclass exercise 1
        string[] name_array = {"Alice", "Bob", "Cathy", "Tom", "Jack"};
        Console.WriteLine($"the second name is: {name_array[1]}, and the fourth name is: {name_array[3]}");
        name_array[4] = "David";
        foreach(string name in name_array){
            Console.Write($"{name} ");
        }
        Console.WriteLine();
        for(int idx=0;idx<5;idx++){
            Console.Write($"{name_array[idx]} ");
        }


    // P10
        /* The 2d-array can be seen as a table where each row has the same amount of column
                    
                        1, 2
                        3, 4
                    
        */  
        // like 1d-array, three ways to declare and initialize 2d-array 
        Console.WriteLine("\n--------Page10----------");
        int[,] two_d_array1 = new int[2,2]{{1,2},{3,4}};
        int[,] two_d_array2 = new int[,]{{1,2},{3,4}};
        int[,] two_d_array3 = {{1,2},{3,4}};

        // // // to access a specific value with row and column numbers
        int x = two_d_array1[0,0];
        int y = two_d_array2[1,1];
        int z = two_d_array3[1,1];

        Console.WriteLine(x);   
        Console.WriteLine(y);    
        Console.WriteLine(z);  

            
        // P12
        Console.WriteLine("\n------------------");
        // Iterate2DArray(){
        int[ , ] arr1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };
        for (int row = 0; row < 3; row++) {
            for (int col = 0; col< 3; col++) {
            Console.Write(arr1[row, col]+" ");
            }
            Console.WriteLine();
        }

        foreach(int num in arr1){
            Console.Write(num + " ");
        }



        // Exercise2
            Console.WriteLine("\n--------Exercise2----------");
        // EvenElement(){
        int[ , ] arr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            // method 1
        foreach(int val in arr){
            if(val%2==0){
            Console.Write(val +" ");
            }
        }
        // method 2
        Console.WriteLine();
        for (int row = 0; row < 3; row++) {
            for (int col = 0; col<=2; col++) {
            if(arr[row,col]%2==0){
                Console.Write(arr[row, col]+" ");
            }
            }
        }
        
        Console.WriteLine("\n--------JaggedArr----------");
        // Jagged Array
        int[ ][ ] jaggedArr = new int[ ][ ] 
        {
            new int[ ] {1,2,3,4},
            new int[ ] {5,6},
            new int[ ] {7,8,9}
        };
        int num = jaggedArr[2][2];
        Console.WriteLine($"Value of num: {num}");

        foreach(var arr3 in jaggedArr){
            Console.WriteLine(arr3);
        }

    }
}

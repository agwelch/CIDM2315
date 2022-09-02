namespace Week3Code;
class Program
{
    static void Main(string[] args)
    {
        // while loop
        Console.WriteLine("-------while loop----------");
        int i = 0;
        while(i<3){
            Console.WriteLine(i);
            i++;
        }
        
        Console.WriteLine("---------Exercise1--------");
        // Exercise 1
        Console.WriteLine("Please input an integer");
        int N = Convert.ToInt16(Console.ReadLine());
        while(N>0){
            Console.Write("*");
            N--;
        }
        Console.WriteLine("-----------------");

        //Changing start value, comparison and step value to control running times

        i = 0; 
        while (i < 10) 
        { 
            Console.WriteLine(i);
            i++; //i = i+1
        }
        Console.WriteLine("-----------------");

        int j = 2; 
        while (j < 10) 
        { 
            Console.WriteLine(j);
            j+=2; //j=j+2
        }

        Console.WriteLine("-----------------");
        int k = 20; 
        while (k > 0) 
        { 
            Console.WriteLine(k);
            k -= 5;  //k = k-5
        }

        // Exercise 2
        // Q1: Write a program to print all odd numbers that 1<= num <= 10 with while loop 
        Console.WriteLine("-------Exercise2 Q1----------");
        int num = 1;
        while(num<11){
            Console.WriteLine(num);
            num = num+2;
        }
        
        Console.WriteLine("------Exercise1 Q2-----------");
        // Q2: Write a program to print all odd numbers that 1<= num <= 10 with while loop and if statement. 
        num=1;
        while(num<=10){
            if(num%2!=0){
                Console.WriteLine(num);
            }
            num+=1; //num++;
        }
        
        Console.WriteLine("-------for loop---------");       
        // for loop
        for (int z = 0; z<4; z++)
        {
            Console.WriteLine(z); 
        }
        Console.WriteLine("End!");


        Console.WriteLine("-----------------");
        for (int x = 0; x<10; x++)
        {
            Console.WriteLine(x); 
        }
        
        
        Console.WriteLine("-----------------");
        for (int p = 0; p<10; p = p+3 )
        {
            Console.WriteLine(p); 
        }
        
        Console.WriteLine("-----------------");
        for (int q = 10; q>0; q = q-3 )
        {
            Console.WriteLine(q); 
        }

        // Exercise 3
        Console.WriteLine("----Exercise3-----");
        Console.WriteLine("Please input an integer:");
        int n1 = Convert.ToInt16(Console.ReadLine());
        for(int n2 = 0; n2<n1; n2++){
            Console.Write("*");
        }

        Console.WriteLine("\n----Do-While Loop-----");
        int count = 0; // start value
        do{ // do code block
            Console.WriteLine(count);
            count++; //step value
        }
        while(count<5); //comparison, add a semicolon after while statement.

        Console.WriteLine("\n----Break-----");
        int x1 = 0;
        while (x1 < 10)
        {
            if (x1 == 3)
            {
                Console.WriteLine("Break the loop");
                break; // exit while loop
            }
            Console.WriteLine(x1);
            x1++;
        }

        Console.WriteLine("\n----Continue-----");
        int y1 = 0;
        while (y1 < 10)
        {
            if (y1 == 3)
            {
                y1 += 1;
                Console.WriteLine("Skip current round");
                continue; // skip current loop
            }
                Console.WriteLine(y1);
                y1++;
        }


    }
}

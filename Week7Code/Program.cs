namespace Week7Lecture1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Example 1----");
        // example1: 
        // create professor1 object
        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.age = 30;
        p1.PrintInfo();

        // create professor2 object
        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.age = 40;
        p2.PrintInfo();


        Console.WriteLine("--------Example 2----");
        // Example2:create an object of building in the Main method
        Building B1 = new Building();
        B1.name = "Classroom Center";
        B1.address = "Canyon";
        B1.num_rooms = 100;
        B1.PrintBuildingInfo();
        B1.UpdateName("Study Center");
        Console.WriteLine($"The new name is: {B1.name}");

        Console.WriteLine("----Exercise: Student Class----");
        // Exercise: create a Student class
        Student s1 = new Student();
        s1.full_name = "Alice Smith";
        s1.age = 21;
        s1.address = "Amarillo";
        s1.PrintStudentInfo();
        s1.ChangeAddress("Canyon");
        s1.PrintStudentInfo();


        Console.WriteLine("--------Public Bank Account---------");
        PublicBankAccount public1 = new PublicBankAccount();
        public1.balance = 1000;
        Console.WriteLine("Public Account balance is: "+public1.balance);
        public1.balance = 500;
        Console.WriteLine("New Public Account balance is: "+public1.balance);
    
        Console.WriteLine("--------Private Bank Account---------");
        PrivateBankAccount private1 = new PrivateBankAccount();
        private1.saveMoney(1000);
        Console.WriteLine("Private Account Balance is: "+private1.showBalance());

        private1.takeMoney(300);
        Console.WriteLine("New Private Account Balance is: "+private1.showBalance());   
        CreditCard card1 = new CreditCard();

        Console.WriteLine("----Private Variable----");
        card1.setCardNumber(11111);
        Console.WriteLine("Card Number: "+ card1.getCardNumber());

        Console.WriteLine("----Public Property----");
        card1.cardPin = 123; // call property set
        Console.WriteLine("Card Pin: "+ card1.cardPin);// call property set
    }
}


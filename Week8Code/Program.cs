namespace Week8;
class Program
{
    static void Main(string[] args)
    {
        // Constructor 
        Student Alice = new Student(input_id:111, input_age:23, input_name:"Alice Smith");
        Alice.printInfo();
        Student Bob = new Student();
        Bob.printInfo();

        // static keyword
        Customer cus1 = new Customer(inputCustomerName:"Alice");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");
        Customer cus2 = new Customer(inputCustomerName:"Bob");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");

        // this keyword
        Computer dell = new Computer(price:1000, brand:"Dell");
        Computer apple = new Computer(price:2000, brand:"Apple");
        dell.ComparePrice(apple);
        apple.ComparePrice(dell);
    }
}

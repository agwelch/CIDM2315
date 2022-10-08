class Customer{
    public static int countCustomer = 0;
    public string customerName = string.Empty;
    public Customer(string inputCustomerName){
        customerName = inputCustomerName;
        Console.WriteLine($"Customer {inputCustomerName} created!");
        // increase the countCustomer after creating a new customer
        countCustomer += 1;
    }
}
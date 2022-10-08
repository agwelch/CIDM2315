class Computer{
    public int price = 0;
    public string brand = string.Empty;
    public Computer(int price, string brand){
        // this.price refers to price of object
        // price on the right side is local parameter
        this.price = price;
        this.brand = brand;
    }

    // set another Computer object as parameter
    public void ComparePrice(Computer objComputer){
        Console.WriteLine($"Current Object is: {this.brand}");
        if(this.price <= objComputer.price){
            Console.WriteLine($"{this.brand} is cheaper");
        }else{
            Console.WriteLine($"{objComputer.brand} is cheaper");
        }
    }
}
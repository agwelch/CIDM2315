class Student{
    public string full_name;
    public int age;
    public string address;

    public void PrintStudentInfo(){
        Console.WriteLine($"Name: {full_name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }
    public void ChangeAddress(string new_address){
        address = new_address;
    }
}
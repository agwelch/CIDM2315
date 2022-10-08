class Student{
    // define attributes with default value
    public int id = 0;
    public int age = 0;
    public string name = string.Empty;
    public void printInfo(){
        Console.WriteLine($"Student ID: {id}");
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Student age: {age}");
    }

    // Given initial values to attributes when creating an object
    public Student(int input_id, int input_age, string input_name){
        id = input_id;
        age = input_age;
        name = input_name;
    }
    public Student(){
        Console.WriteLine("Create An Empty Object");
    }
}


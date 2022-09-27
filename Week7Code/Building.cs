class Building{
    public string name;
    public string address;
    public int num_rooms;
    public void UpdateName(string new_name){
        name = new_name;
    }
    public void PrintBuildingInfo(){
        Console.WriteLine($"Building name: {name}");
        Console.WriteLine($"Building address: {address}");
        Console.WriteLine($"Building number of rooms: {num_rooms}");
    }
}




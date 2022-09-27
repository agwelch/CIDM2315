class StudentUML{
    public int studentID;
    public string studentName;
    private double studentGPA= 0;
    // // could set private attribute as public property
    // public double studentGPA {get;set;}
    public void PrintInfo(){
        //empty method body
    }
    public void setGPA(double newGPA){
        studentGPA = newGPA;
    }
    public double getGPA(){
        return studentGPA;
    }
}
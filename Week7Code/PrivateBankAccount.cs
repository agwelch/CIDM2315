class PrivateBankAccount{
    // set blance to private
    // it cannot be accessed from outside class
    private int balance;

    public void saveMoney(int amount){
        balance = balance +amount;
    }
    public void takeMoney(int amount){
        balance = balance - amount;
    }
    public int showBalance(){
        return balance;
    }

}


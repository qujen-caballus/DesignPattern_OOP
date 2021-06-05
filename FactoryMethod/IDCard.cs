using framework;


namespace IDCard{
public class IDCard : Product{
    private string owner;
    public IDCard(string owner){
        System.Console.WriteLine("using" + owner+ "'s card");
        this.owner = owner;
    }
    public override void use(){
        System.Console.WriteLine("using" + owner + "'s card");
    }
    public string getOwner(){
        return owner;
    }

}
}
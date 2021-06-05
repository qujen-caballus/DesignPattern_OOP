using framework;
using System.Collections.Generic;

namespace IDCard{
public class IDCardFactory : Factory{
    private List<string> owners = new List<string>();
    protected override Product createProduct(string owner){
        return new IDCard(owner);
    }
    protected override void registerProduct(Product product){
        owners.Add(((IDCard)product).getOwner());
    }
    public List<string> getOwners(){
        return owners;
    }
}
}
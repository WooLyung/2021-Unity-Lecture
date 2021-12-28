public class Item1 : Item
{
    public override string Name => "Item1";

    public override int MaxStack => 10;

    public override Item Clone()
    {
        var clone = new Item1();
        clone.Amount = Amount;
        return clone;
    }
}
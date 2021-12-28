public class Item3 : Item
{
    public override string Name => "Item3";

    public override int MaxStack => 10;

    public override Item Clone()
    {
        var clone = new Item3();
        clone.Amount = Amount;
        return clone;
    }
}
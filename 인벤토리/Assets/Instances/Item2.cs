public class Item2 : Item
{
    public override string Name => "Item2";

    public override int MaxStack => 10;

    public override Item Clone()
    {
        var clone = new Item2();
        clone.Amount = Amount;
        return clone;
    }
}
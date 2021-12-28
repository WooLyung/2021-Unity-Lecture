public abstract class Item
{
    int _amount = 1;

    public abstract string Name { get; }

    public abstract int MaxStack { get; }

    public int Amount
    {
        get => _amount;
        set
        {
            if (value > MaxStack)
                _amount = MaxStack;
            else if (value < 0)
                _amount = 0;
            else
                _amount = value;
        }
    }

    public abstract Item Clone();
}
namespace Definitions.Runtime;

public class Property<T>
{
    bool IsHard = true;

    T Hard;
    Func<T> Soft;

    public Property()
    {
        Hard = default!;
        Soft = null!;
    }

    public T Value
    {
        get => IsHard ? Hard : Soft();
        set
        {
            IsHard = true;
            Hard = value;
        }
    }

    public Func<T> Func
    {
        set
        {
            IsHard = false;
            Soft = value;
        }
    }
}

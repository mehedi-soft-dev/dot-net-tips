namespace IndexerExample;

internal class MyList
{
    private int[] items;

    public MyList(int[] items)
    {
        this.items = items;
    }

    public int this[int index]
    {
        get
        {
            return items[index];
        }
        set
        {
            items[index] = value;
        }
    }
}

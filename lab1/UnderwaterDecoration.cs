class UnderwaterDecoration : Decoration    //conrete product B2
{
    public UnderwaterDecoration(string _kind, int _coordX, int _coordY) : base(_kind, _coordX, _coordY)
    { }

    public override string ToString()
    {
        return "Underwater-" + base.ToString();
    }
}
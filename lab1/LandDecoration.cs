class LandDecoration : Decoration      //conrete product B1
{
    public LandDecoration(string _kind, int _coordX, int _coordY) : base(_kind, _coordX, _coordY)
    { }

    public override string ToString()
    {
        return "Land-" + base.ToString();
    }
}
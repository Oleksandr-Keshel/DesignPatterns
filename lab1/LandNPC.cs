class LandNPC : NPC   //conrete productA1
{
    public LandNPC(string _name, int _coordX, int _coordY, int _lives) : base(_name, _coordX, _coordY, _lives)
    { }

    public override string ToString()
    {
        return "Land-" + base.ToString();
    }
}
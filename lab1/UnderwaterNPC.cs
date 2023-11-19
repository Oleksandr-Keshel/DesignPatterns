 class UnderwaterNPC: NPC //conrete productA2
{
    public UnderwaterNPC(string _name, int _coordX, int _coordY, int _lives) : base(_name, _coordX, _coordY, _lives)
    { }

    public override string ToString()
        {
            return "Unerwater-" + base.ToString();
        }
}
abstract class NPC  //abstract product A
{
    public string name = "No Name";
    public int coordX {get;set;}
    public int coordY {get;set;}
    public int lives {get;set;}

    public NPC(string _name, int _coordX, int _coordY, int _lives )
    {
        name = _name;
        coordX = _coordX;
        coordY = _coordY;
        lives = _lives;
    }

    public override string ToString()
    {
        return $"{name}";
    }

}
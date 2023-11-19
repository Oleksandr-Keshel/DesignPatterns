abstract class Decoration //abstract product B
{
    public string kind;
    public int coordX {get;set;}
    public int coordY {get;set;}
    public Decoration(string _kind, int _coordX, int _coordY){
        kind = _kind;
        coordX = _coordX;
        coordY = _coordY;
    }
    public override string ToString()
    {
        return $"{kind}";
    }

}
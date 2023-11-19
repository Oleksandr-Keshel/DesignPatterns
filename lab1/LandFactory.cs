class LandFactory : IAbstractFactory
{
    public NPC CreateNPC(string name, int coordX, int coordY, int lives)
    {
        return new LandNPC(name, coordX, coordY, lives);
    }
    public Decoration CreateDecoration(string kind, int coordX, int coordY)
    {
        return new LandDecoration(kind, coordX, coordY); 
    }


}
class UnderwaterFactory : IAbstractFactory
{
    public NPC CreateNPC(string name, int coordX, int coordY, int lives)
    {
        return new UnderwaterNPC(name, coordX, coordY, lives);
    }
    public Decoration CreateDecoration(string kind, int coordX, int coordY)    
    {
        return new UnderwaterDecoration(kind, coordX, coordY); 
    }


    
}
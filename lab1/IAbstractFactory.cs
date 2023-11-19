interface IAbstractFactory  //Abstract Factory
{
    NPC CreateNPC(string name, int coordX, int coordY, int lives); 
    Decoration CreateDecoration(string kind,int coordX, int coordY);
}
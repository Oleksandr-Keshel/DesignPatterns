using System.Linq;
using System.Collections.Generic;

static class Game
{
    private static IAbstractFactory SelectFactory(string level)
    {
        if(level == "Land"){
            return new LandFactory();
        } else if(level == "Underwater"){
            return new UnderwaterFactory();
        }else{
            throw new Exception("This level does not exist");
        }
    }
    private static List<NPC> GetNPCs(IAbstractFactory factory)
    {
        List<NPC> npcList = new List<NPC>();
        npcList.Add(factory.CreateNPC("Alex", 2,2, 10));
        npcList.Add(factory.CreateNPC("John", 2,3, 10));
        npcList.Add(factory.CreateNPC("Tailor", 5,5, 10));
        return npcList;
    }
    private static List<Decoration> GetDecorations(IAbstractFactory factory)
    {
        List<Decoration> decorations = new List<Decoration>();
        decorations.Add(factory.CreateDecoration("tree", 1,2));
        decorations.Add(factory.CreateDecoration("rock", 2,9));
        decorations.Add(factory.CreateDecoration("pineapple", 5,6));
        return decorations;
    }

    public static object [,] GenerateGame(string level, int mapSize) 
    {  
        IAbstractFactory factory = SelectFactory(level); // here we ensure that land objects can't interact with underwater 
        List<NPC> npcList = GetNPCs(factory);
        List<Decoration> decorations = GetDecorations(factory);

        var minMapSize = 10; // minimal size of a map
        mapSize =  mapSize > 10 ? mapSize : minMapSize;
        object [,] map = new object [mapSize,mapSize];  //create a map of the game

        foreach (var item in npcList)
        {
            int x = item.coordX;
            int y = item.coordY;
            map[x,y] = item;
        }
        foreach (var item in decorations)
        {
            int x = item.coordX;
            int y = item.coordY;
            map[x,y] = item;
        }
        // for (int i = 0; i < map.GetLength(0); i++)
        // {
        //     for (int j = 0; j < map.GetLength(1); j++)
        //     {
        //         System.Console.Write(map[i,j]);
        //     }
        //     System.Console.WriteLine();
        // }
        return map;
    }
}
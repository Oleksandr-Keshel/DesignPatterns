/*
Розробити підсистему для завантаження збереження гри в 2D.Описати клас для створення NPC (Ім'я, координати x та y, кількість життів) та декорацій ( вид, наприклад, камінь, дерево та координати). Передбачити існування підводних та наземних рівнів. Врахувати, що підводні NPC не можуть взаємодіяти з наземними декораціями і навпаки. Система отримує список об'єктів, вид рівня (наземний чи підводний) та розміри карти, а повертає рівень гри - .двовимірний масив із розставленими об'єктами.
*/

// Доцільно використати патерн Abstract Fcatory. Він дає можливість стаорювати обʼєкти, які є чимось повʼязані(у нашому
// випадку обʼєкти повʼязані рівнем гри). 
internal class Program
{
    static void Main(string[] args)
    {
        var csvPath = "game_map.csv";
        var gameMap = Game.GenerateGame("Land", 2);


        using (StreamWriter outfile = new StreamWriter(csvPath))
        {
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                string content = "";
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    content += gameMap[i, j] + ",";
                }
                outfile.WriteLine(content);
            }
        }
    }
}

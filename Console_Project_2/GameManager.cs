using System;

public class GameManager
{
    Map map;
    Player player;
    Rules rules;
    PrintText printText;

    public void Run()
    {
        Init();

        while (true)
        {
            Console.SetCursorPosition(0, 5);
            map.PrintMap();

            ConsoleKey inputKey = player.UserInput();
            rules.PlayerMove(inputKey);
        }
    }
    
    void Init()
    {
        Console.CursorVisible = false;
        map = new Map();
        player = new Player(); 
        rules = new Rules(player, map);
        printText = new PrintText();

        map.Init();
        map.SpawnPlayer(player);
        map.Bush(Define.BUSH);
        map.Water(Define.WATER);

    }
}

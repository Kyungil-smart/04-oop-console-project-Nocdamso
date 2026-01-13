using System;

public class GameManager
{
    Map map;
    Player player;
    Enemy enemy;
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

            // ENEMY가 사라지면 승리, PLAYER가 사라지면 패배
        }
    }
    
    void Init()
    {
        Console.CursorVisible = false;
        map = new Map();
        player = new Player();
        enemy = new Enemy();
        rules = new Rules(player, map);
        printText = new PrintText();

        map.Init();
        map.SpawnPlayer(player);
        map.SpawnEnemy(enemy);
        map.Bush(Define.BUSH);
        map.Water(Define.WATER);
    }
}

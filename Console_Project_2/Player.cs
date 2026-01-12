


using System;
using System.Security.Cryptography.X509Certificates;

public class Player
{
    public Define.Position PlayerPos;
    public char OnTile = Define.EMPTY;

    public void Init(int posX, int posY)
    {
        PlayerPos = new Define.Position() { X = posX, Y = posY };
        OnTile = Define.EMPTY;
    }

    public ConsoleKey UserInput()
    {
        ConsoleKey inputKey;

        while (true)
        {
            inputKey = Console.ReadKey(true).Key;

            if (ConsoleKey.W == inputKey ||
                ConsoleKey.A == inputKey ||
                ConsoleKey.S == inputKey ||
                ConsoleKey.D == inputKey ||
                ConsoleKey.Spacebar == inputKey)
                break;

        }
        return inputKey;
    }

    public void Move(Define.Position nextPos, char nextTile)
    {
        PlayerPos = nextPos;
        OnTile = nextTile;
    }
}
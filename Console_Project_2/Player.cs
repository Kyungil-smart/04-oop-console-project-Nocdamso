


using System;

public class Player
{
    public Define.Position PlayerPos;

    public void Init(int posX, int posY)
    {
        PlayerPos = new Define.Position() { X = posX, Y = posY };
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

    public void Move(Define.Position nextPos)
    {
        PlayerPos = nextPos;
    }
}
using System;

public class GameManager
{
    public static bool IsGameOver { get; set; }
    public void Run()
    {
        Init();

        while (!IsGameOver)
        {

        }
    }

    private void Init()
    {
        IsGameOver = false;
    }
}




using System;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

public class Map
{
    char[,] map;
    int height;
    int width;
    
    public void Init()
    {
        width = 100;
        height = 20;

        map = new char[height, width];

        for (int i = 0; i < map.GetLength(0); i++)
        {
            for(int j = 0; j < map.GetLength(1); j++)
            {
                if (i == 0 || j == 0 || i == height - 1 || j == width - 1)
                    map[i, j] = Define.WALL;
                else
                    map[i, j] = Define.EMPTY;
            }
        }
        for (int i = 1; i < 6; i++)
            map[i, 15] = Define.WALL;

        for (int i = 13; i < 18; i++)
            map[i, 25] = Define.WALL;
    }

    public void PrintMap()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j]);
            }

            Console.WriteLine();
        }
    }

    public char GetCell(int x, int y) => map[x, y];
    public void SetCell(int x, int y, char value) => map[x, y] = value;

    public void SpawnPlayer(Player player)
    {
        int x = 1, y = 2;
        SetCell(x, y, Define.PLAYER);
        player.Init(x, y);
    }

   public void Bush(char bush)
   {
        for (int x = 14; x < 19; x++)
        {
            for (int y = x; y < 19; y++)
            {
                SetCell(y, x, bush);
            }
        }

        for (int x = 1; x < 5; x++)
        {
            for (int y = 40; y < 46 - x; y++)
            {
                SetCell(x, y, bush);
            }
        }

        for (int x = 14; x < 19; x++)
        {
            for (int y = 70; y < 80; y++)
            {
                SetCell(x, y, bush);
            }
        }
    }

    public void Water(char water)
    {
        for (int i = 0; i < 10; i++)
        {
            int x = 13 - i;
            int j = 35 + (i * 3);

            for (int y = j; y < j +15; y++)
            {
                SetCell(x, y, water);
            }
        }   
    }
}

    


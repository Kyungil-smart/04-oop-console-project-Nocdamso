


using System;
using System.Security.Cryptography.X509Certificates;

public class Player
{
    public Define.Position PlayerPos;
    public char OnTile = Define.EMPTY;

    public int HP = 10;
    public int MaxHP = 10;

    public int AttackValue = 2;

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

    public void MoveSpeed()
    {

    }

    public void Attack()
    {
        // 스페이스 바를 입력하면 마지막으로 바라본 방향으로 BULLET이 발사
        // BULLET은 하나만 발사할 수 있으며 WALL, ENEMY 혹은 상대의 BULLET과 충돌하면 소멸, 소멸되면 다시 발사 가능
        // BULLET은 BUSH나 WATER는 그냥 지나감

        // BULLET이 PLAYER나 ENEMY에게 충돌 시 체력이 없다면 사라지고 체력이 남아있다면 HIT을 띄우고 PLAYER나 ENEMY로 원복
    }

    public void HealtPoint()
    {

    }
}
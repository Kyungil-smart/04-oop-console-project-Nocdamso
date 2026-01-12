


using System;

public class Rules
{
    Player player;
    Map map;
    
    public Rules(Player player, Map map)
    {
        this.player = player;
        this.map = map;
    }

    public bool PlayerMove(ConsoleKey inputKey)
    {
        Define.Position nextPos = player.PlayerPos;
        Define.eMoveDir dir = Define.eMoveDir.NONE;

        switch (inputKey)
        {
            case ConsoleKey.W:
                dir = Define.eMoveDir.UP;
                nextPos.X--;
                break;

            case ConsoleKey.A:
                dir = Define.eMoveDir.LEFT;
                nextPos.Y--;
                break;

            case ConsoleKey.S:
                dir = Define.eMoveDir.DOWN;
                nextPos.X++;
                break;

            case ConsoleKey.D:
                dir = Define.eMoveDir.RIGHT;
                nextPos.Y++;
                break;

            default:

                break;
        }

        char target = map.GetCell(nextPos.X, nextPos.Y);

        if (target == Define.WALL || target == Define.WATER || target == Define.ENEMY)
            return false;
        
        map.SetCell(player.PlayerPos.X, player.PlayerPos.Y, player.OnTile);
        char nextTile = target;
        player.Move(nextPos, nextTile);

        if (target == Define.BUSH)
        {
            map.SetCell(nextPos.X, nextPos.Y, Define.BUSH);
        }
        else
        {
            map.SetCell(nextPos.X, nextPos.Y, Define.PLAYER);
        }
        return true;
    }
}

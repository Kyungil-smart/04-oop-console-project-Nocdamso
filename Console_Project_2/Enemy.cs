


public class Enemy
{
    public Define.Position EnemyPos;
    public char OnTile = Define.EMPTY;

    public void Init(int posX, int posY)
    {
        EnemyPos = new Define.Position() { X = posX, Y = posY };
        OnTile = Define.EMPTY;
    }
}
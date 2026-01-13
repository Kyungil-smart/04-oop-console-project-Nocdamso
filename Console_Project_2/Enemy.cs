


public class Enemy
{
    public Define.Position EnemyPos;
    public char OnTile = Define.EMPTY;

    public int HP = 10;
    public int MaxHP = 10;

    public int AttackValue = 2;


    public void Init(int posX, int posY)
    {
        EnemyPos = new Define.Position() { X = posX, Y = posY };
        OnTile = Define.EMPTY;
    }

    public void Move()
    {
        // 플레이어와 동일한 조건이나 플레이어를 공격해서 없앨목적으로 자동움직임
    }

    public void MoveSpeed()
    {

    }

    public void Attack()
    {
        // 플레이어와 동일한 조건
    }

    public void HealtPoint()
    {

    }
}

// PLAYER와 ENEMY를 하나의 부모객체에서 상속 ?
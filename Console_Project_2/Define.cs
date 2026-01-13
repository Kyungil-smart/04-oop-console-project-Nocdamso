


public class Define
{
    public static readonly char PLAYER = 'P';
    public static readonly char ENEMY = 'E';
    public static readonly char WALL = '#';
    public static readonly char EMPTY = ' ';
    public static readonly char BUSH = '/';
    public static readonly char WATER = '~';
    public static readonly char BULLET = '●';
    public static readonly char HIT = '!';
    public static readonly char POWERITEM = '♤';
    public static readonly char SPEEDITEM = '☆';
    public static readonly char BULLETITEM = '♧';


    public struct Position
    {
        public int X {  get; set; }
        public int Y { get; set; }
    }

    public enum eMoveDir
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        SHOOT,

        NONE
    }
}
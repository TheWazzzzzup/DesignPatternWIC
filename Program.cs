// Shallow Copy Example
class Program
{
    static void Main(string[] args)
    {
        Enemy yossi = new(health: 102,nickName: "YosBlet");

        Enemy Liza = yossi;


    }
}

class Enemy
{
    protected float damage;
    protected string nickName;
    protected int health;

    public Enemy(int health, string nickName, float damage = 7 )
    {
        this.health = health;
        this.damage = damage;
        this.nickName = nickName;
    }

    public Enemy(Enemy copy)
    {
        this.health = copy.health;
        this.nickName = copy.nickName;
    }
}
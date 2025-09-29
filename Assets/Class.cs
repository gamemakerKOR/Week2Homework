using UnityEngine;

public class Player
{
    public string ID;
    protected int currentHP;
    protected int damage;

    public Player(string _ID = "?", int _currentHP = 0,int damage=0)
    {
        this.ID = _ID;
        this.currentHP = _currentHP;
        this.damage = damage;
    }

    public int show_HP()
    {
        return this.currentHP;
    }

    public int Damaged(int damage)
    {
        this.currentHP -= damage;
        return damage;
    }

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = this.ID;
        clone.currentHP = this.currentHP;
        clone.damage = this.damage;

        return clone;
    }

    public void Hit(enemy enemy)
    {
        enemy.TakeDamage(this.damage);
    }
}

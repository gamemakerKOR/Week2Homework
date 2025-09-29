using UnityEngine;

public class Player
{
    public string ID;
    private int currentHP;

    public Player(string _ID = "?", int _currentHP = 0)
    {
        _ID = this.ID;
        _currentHP = this.currentHP;
    }

    public int show_HP()
    {
        return this.currentHP;
    }

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}

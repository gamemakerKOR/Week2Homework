using UnityEngine;

public class Property
{
    private int currentHP;
    public int HP
    {
        get => currentHP;
        set
        {
            if (value > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }
}

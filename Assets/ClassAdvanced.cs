using UnityEngine;

public class npc:Player
{
    public npc(string _ID, int _HP)
    {
        base.ID = _ID;
        base.currentHP = _HP;
    }
    public void talk()
    {
        Debug.Log($"�ȳ��ϼ��� �� �̸��� {base.ID}�Դϴ�.");
    }
}

public class enemy
{
    protected int currentHP;
    protected int defaultDamage;

    public enemy(int _currentHP=0, int _defaultDamage = 0)
    {
        this.currentHP=_currentHP;
        this.defaultDamage = _defaultDamage;
    }

    public virtual void TakeDamage(int damage) {}
    public virtual void Attack(Player player) {}
}

public class Bokoblin : enemy
{
    public Bokoblin() : base(30,30) { }

    public override void TakeDamage(int damage)
    {
        base.currentHP-=damage;
        Debug.Log($"���ں�:{damage}�� ���ظ� ����. ���� ü��{base.currentHP}.");
    }
    public override void Attack(Player player)
    {
        Debug.Log("���ں��� ������ ���Ž�!!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}�� ���ں����� {base.defaultDamage}�� ���ظ� ����. ���� ü��{player.show_HP()}");
    }
}

public class Chuchu : enemy
{
    public Chuchu() : base(20,5) { }

    public override void TakeDamage(int damage)
    {
        base.currentHP -= damage;
        Debug.Log($"����:{damage}�� ���ظ� ����. ���� ü��{base.currentHP}.");
    }

    public override void Attack(Player player)
    {
        Debug.Log("������ �����ġ��!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}�� ���򿡰� {base.defaultDamage}�� ���ظ� ����. ���� ü��{player.show_HP()}");
    }
}

public class Moliblin : enemy
{
    public Moliblin() : base(60,40) { }

    public override void TakeDamage(int damage)
    {
        base.currentHP -= damage;
        Debug.Log($"�𸮺�:{damage}�� ���ظ� ����. ���� ü��{base.currentHP}.");
    }

    public override void Attack(Player player)
    {
        Debug.Log("�𸮺��� ������ ���Ž�!!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}�� �𸮺����� {base.defaultDamage}�� ���ظ� ����. ���� ü��{player.show_HP()}");
    }
}
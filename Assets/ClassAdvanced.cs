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
        Debug.Log($"안녕하세요 제 이름은 {base.ID}입니다.");
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
        Debug.Log($"보코블린:{damage}의 피해를 입음. 남은 체력{base.currentHP}.");
    }
    public override void Attack(Player player)
    {
        Debug.Log("보코블린의 몽둥이 스매시!!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}가 보코블린에게 {base.defaultDamage}의 피해를 입음. 남은 체력{player.show_HP()}");
    }
}

public class Chuchu : enemy
{
    public Chuchu() : base(20,5) { }

    public override void TakeDamage(int damage)
    {
        base.currentHP -= damage;
        Debug.Log($"츄츄:{damage}의 피해를 입음. 남은 체력{base.currentHP}.");
    }

    public override void Attack(Player player)
    {
        Debug.Log("츄츄의 몸통박치기!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}가 츄츄에게 {base.defaultDamage}의 피해를 입음. 남은 체력{player.show_HP()}");
    }
}

public class Moliblin : enemy
{
    public Moliblin() : base(60,40) { }

    public override void TakeDamage(int damage)
    {
        base.currentHP -= damage;
        Debug.Log($"모리블린:{damage}의 피해를 입음. 남은 체력{base.currentHP}.");
    }

    public override void Attack(Player player)
    {
        Debug.Log("모리블린의 몽둥이 스매시!!");
        player.Damaged(base.defaultDamage);
        Debug.Log($"{player.ID}가 모리블린에게 {base.defaultDamage}의 피해를 입음. 남은 체력{player.show_HP()}");
    }
}
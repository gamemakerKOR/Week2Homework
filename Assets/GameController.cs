
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Method methodEx;
    private Player player1;
    private Player player2;
    private npc npc1;

    private void Awake()
    {
        methodEx = new Method();
        Debug.Log($"1+2={methodEx.Add(1, 2)}");

        player1 = new Player("Mario", 1000,10);

        player2 = player1.DeepCopy();
        player2.ID = "link";

        Debug.Log($"ID:{player1.ID}, HP={player1.show_HP()}");
        Debug.Log($"ID:{player2.ID}, HP={player2.show_HP()}");

        npc1 = new npc("zelda",1000);
        npc1.talk();

        enemy bokoblin1 = new Bokoblin();
        if (bokoblin1 is Bokoblin)
        {
            Debug.Log("enemy type is Bokoblin");
        }
        enemy chuchu1 = new Chuchu();
        player1.Hit(bokoblin1);
        bokoblin1.Attack(player1);
        chuchu1.Attack(player2);

    }                                                
}

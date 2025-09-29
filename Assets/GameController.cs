
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

        ClassAdditiveFunction p = new ClassAdditiveFunction();
        p.Method1();
        Child c = new Child();
        c.Method1();
        ClassAdditiveFunction pc = new Child();
        pc.Method1();
        Struct struct1;
        struct1.x = 1;
        Debug.Log($"struct1의 변수 값:{struct1.x}");
        var a = (Name: "김유록", 2022136032);
        Debug.Log($"{a.Name},{a.Item2}");
        int j = ClassAdditiveFunction.Method3();
        ClassAdditiveFunction.talk = "저는 정적변수입니다.쟤는 정적함수 반환값입니다";
        Debug.Log($"{ClassAdditiveFunction.talk}, {j}");
        string str = "string클래스 확장하기";
        str.PrintData();
        Property property=new Property();
        property.HP = 100;
        Debug.Log($"Player HP: {property.HP}");
        property.HP = -100;
        Debug.Log($"Player HP: {property.HP}");
    }                                                
}

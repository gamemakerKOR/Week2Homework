
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Method methodEx;
    private Player player1;
    private Player player2;

    private void Awake()
    {
        methodEx = new Method();
        Debug.Log($"1+2={methodEx.Add(1, 2)}");

        player1 = new Player("a", 1000);

        player2 = player1.DeepCopy();
        player2.ID = "link";

        Debug.Log($"ID:{player1.ID}, HP={player1.show_HP()}");
        Debug.Log($"ID:{player2.ID}, HP={player2.show_HP()}");
    }                                                
}

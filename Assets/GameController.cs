
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Method methodEx;
    

    private void Awake()
    {
        methodEx = new Method();
        Debug.Log($"1+2={methodEx.Add(1, 2)}");

        
    }                                                
}

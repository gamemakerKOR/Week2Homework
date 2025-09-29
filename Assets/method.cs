using UnityEngine;

public class Method
{

    public int Add(int num1, int num2)
    {
        int result=num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result=num1 * num2;
        Debug.Log($"{num1}x{num2}={result}");
    }
}
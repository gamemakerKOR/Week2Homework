using UnityEngine;

public partial class ClassAdditiveFunction
{
    public static string talk;

    public void Method1()
    {
        Debug.Log("부모클래스 함수1 호출");
    }

    public static int Method3()
    {
        return 1;
    }
}

public class Child:ClassAdditiveFunction
{
    public new void Method1()
    {
        Debug.Log("자식클래스 함수1 호출");
    }
    public sealed override void Method2()
    {
        Debug.Log("자식 함수2 호출");
    }
}

public struct Struct
{
    public int x;
}

public static class StringExtension
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
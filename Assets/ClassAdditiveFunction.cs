using UnityEngine;

public partial class ClassAdditiveFunction
{
    public static string talk;

    public void Method1()
    {
        Debug.Log("�θ�Ŭ���� �Լ�1 ȣ��");
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
        Debug.Log("�ڽ�Ŭ���� �Լ�1 ȣ��");
    }
    public sealed override void Method2()
    {
        Debug.Log("�ڽ� �Լ�2 ȣ��");
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string pname = "���¿�";
    private int age = 26;
    private int height = 123;
    private int weight = 123;
    private string hobby = "����";
    private string favoriteFood = "Ÿ�ھ߳�";
    private string mbti = "INFJ";
    private string favoriteMusicGenre = "Lo-fi";
    private string bloodType = "O";
    private string favoriteColor = "�Ķ���";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction();
    }

    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + pname + "�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
        Debug.Log($"Ű�� {height}cm�̰� �����Դ� {weight}kg�Դϴ�.");
        Debug.Log($"��̴� {hobby}�̰�, �����ϴ� ������ {favoriteFood}�Դϴ�.");
        Debug.Log($"MBTI�� {mbti}�Դϴ�.");
        Debug.Log($"�����ϴ� ���� �帣�� {favoriteMusicGenre}�Դϴ�.");
        Debug.Log($"�������� {bloodType}���Դϴ�.");
        Debug.Log($"�����ϴ� ������ {favoriteColor}�Դϴ�.");
    }
}
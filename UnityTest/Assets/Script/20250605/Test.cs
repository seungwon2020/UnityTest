using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string pname = "정승원";
    private int age = 26;
    private int height = 123;
    private int weight = 123;
    private string hobby = "게임";
    private string favoriteFood = "타코야끼";
    private string mbti = "INFJ";
    private string favoriteMusicGenre = "Lo-fi";
    private string bloodType = "O";
    private string favoriteColor = "파란색";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction();
    }

    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은 " + pname + "입니다.");
        Debug.Log($"저의 나이는 {age}살 입니다.");
        Debug.Log($"키는 {height}cm이고 몸무게는 {weight}kg입니다.");
        Debug.Log($"취미는 {hobby}이고, 좋아하는 음식은 {favoriteFood}입니다.");
        Debug.Log($"MBTI는 {mbti}입니다.");
        Debug.Log($"좋아하는 음악 장르는 {favoriteMusicGenre}입니다.");
        Debug.Log($"혈액형은 {bloodType}형입니다.");
        Debug.Log($"좋아하는 색깔은 {favoriteColor}입니다.");
    }
}
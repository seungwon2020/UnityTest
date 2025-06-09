using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Rarity
{
    일반 = 1,
    희귀 = 2,
    전설 = 3
}

public class GachaItem
{
    public string name;
    public Rarity rarity;

    public GachaItem(string name, Rarity rarity)
    {
        this.name = name;
        this.rarity = rarity;
    }
}

public class GachaCont : MonoBehaviour
{
    private List<GachaItem> gachaPool = new List<GachaItem>();

    void Start()
    {
        // 15명의 캐릭터 등록
        gachaPool.Add(new GachaItem("고블린", Rarity.일반));
        gachaPool.Add(new GachaItem("슬라임", Rarity.일반));
        gachaPool.Add(new GachaItem("늑대인간", Rarity.일반));
        gachaPool.Add(new GachaItem("좀비", Rarity.일반));
        gachaPool.Add(new GachaItem("해골병사", Rarity.일반));

        gachaPool.Add(new GachaItem("기사", Rarity.희귀));
        gachaPool.Add(new GachaItem("궁수", Rarity.희귀));
        gachaPool.Add(new GachaItem("마법사", Rarity.희귀));
        gachaPool.Add(new GachaItem("도적", Rarity.희귀));
        gachaPool.Add(new GachaItem("성기사", Rarity.희귀));

        gachaPool.Add(new GachaItem("드래곤", Rarity.전설));
        gachaPool.Add(new GachaItem("마왕", Rarity.전설));
        gachaPool.Add(new GachaItem("천사", Rarity.전설));
        gachaPool.Add(new GachaItem("악마", Rarity.전설));
        gachaPool.Add(new GachaItem("불사조", Rarity.전설));
    }

    public void DoGacha10()
    {
        List<GachaItem> results = new List<GachaItem>();

        for (int i = 0; i < 10; i++)
        {
            GachaItem selected = GetRandomItem();
            results.Add(selected);
        }

        Debug.Log("=== 10연 가챠 결과 ===");
        foreach (var item in results)
        {
            Debug.Log($"[{item.rarity}] {item.name}");
        }
    }

    GachaItem GetRandomItem()
    {
        int rand = Random.Range(0, 100);

        if (rand < 60) // 60% 일반
            return GetRandomByRarity(Rarity.일반);
        else if (rand < 90) // 30% 희귀
            return GetRandomByRarity(Rarity.희귀);
        else // 10% 전설
            return GetRandomByRarity(Rarity.전설);
    }

    GachaItem GetRandomByRarity(Rarity rarity)
    {
        List<GachaItem> filtered = gachaPool.FindAll(item => item.rarity == rarity);
        return filtered[Random.Range(0, filtered.Count)];
    }
}
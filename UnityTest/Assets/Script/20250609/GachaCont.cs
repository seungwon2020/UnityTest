using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Rarity
{
    �Ϲ� = 1,
    ��� = 2,
    ���� = 3
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
        // 15���� ĳ���� ���
        gachaPool.Add(new GachaItem("���", Rarity.�Ϲ�));
        gachaPool.Add(new GachaItem("������", Rarity.�Ϲ�));
        gachaPool.Add(new GachaItem("�����ΰ�", Rarity.�Ϲ�));
        gachaPool.Add(new GachaItem("����", Rarity.�Ϲ�));
        gachaPool.Add(new GachaItem("�ذ񺴻�", Rarity.�Ϲ�));

        gachaPool.Add(new GachaItem("���", Rarity.���));
        gachaPool.Add(new GachaItem("�ü�", Rarity.���));
        gachaPool.Add(new GachaItem("������", Rarity.���));
        gachaPool.Add(new GachaItem("����", Rarity.���));
        gachaPool.Add(new GachaItem("�����", Rarity.���));

        gachaPool.Add(new GachaItem("�巡��", Rarity.����));
        gachaPool.Add(new GachaItem("����", Rarity.����));
        gachaPool.Add(new GachaItem("õ��", Rarity.����));
        gachaPool.Add(new GachaItem("�Ǹ�", Rarity.����));
        gachaPool.Add(new GachaItem("�һ���", Rarity.����));
    }

    public void DoGacha10()
    {
        List<GachaItem> results = new List<GachaItem>();

        for (int i = 0; i < 10; i++)
        {
            GachaItem selected = GetRandomItem();
            results.Add(selected);
        }

        Debug.Log("=== 10�� ��í ��� ===");
        foreach (var item in results)
        {
            Debug.Log($"[{item.rarity}] {item.name}");
        }
    }

    GachaItem GetRandomItem()
    {
        int rand = Random.Range(0, 100);

        if (rand < 60) // 60% �Ϲ�
            return GetRandomByRarity(Rarity.�Ϲ�);
        else if (rand < 90) // 30% ���
            return GetRandomByRarity(Rarity.���);
        else // 10% ����
            return GetRandomByRarity(Rarity.����);
    }

    GachaItem GetRandomByRarity(Rarity rarity)
    {
        List<GachaItem> filtered = gachaPool.FindAll(item => item.rarity == rarity);
        return filtered[Random.Range(0, filtered.Count)];
    }
}
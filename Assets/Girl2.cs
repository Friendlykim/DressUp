using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl2 : MonoBehaviour
{
    public Transform hairGroup;
    public Transform upperGroup;
    public Transform bodyGroup;
    private int HairCount;
    private int UpperCount;
    private int BodyCount;

    List<GameObject> hairs = new List<GameObject>();
    List<GameObject> uppers = new List<GameObject>();
    List<GameObject> bodys = new List<GameObject>();

    private void Start()
    {
        MakeDress(hairGroup, hairs);
        MakeDress(upperGroup, uppers);
        MakeDress(bodyGroup, bodys);

        SetDress(hairs, 0);
        SetDress(uppers, 0);
        SetDress(bodys, 0);

        HairCount = 0;
        UpperCount = 0;
        BodyCount = 0;
    }


    void MakeDress(Transform group,List<GameObject> list)
    {
        foreach(Transform dress in group)
        {
            dress.gameObject.SetActive(false);
            list.Add(dress.gameObject);
        }
        list[0].SetActive(true);
    }

    void SetDress(List<GameObject> list,int n)
    {
        for (int i = 0; i < list.Count; i++)
            list[i].SetActive(false);
        list[n].SetActive(true);
    }

    public void HairButton()
    {
        SetDress(hairs,HairCount);
            HairCount += 1;
        if (HairCount >= hairs.Count - 1)
            HairCount = 0;
    }

    public void UpButton()
    {
        SetDress(uppers, UpperCount);

            UpperCount += 1;
        if (UpperCount >= uppers.Count-1)
            UpperCount = 1;
    }
    public void BodyButton()
    {
        SetDress(bodys, BodyCount);

            BodyCount += 1;
        if (BodyCount >= bodys.Count-1)
        {
            BodyCount = 1;
        }

    }
}

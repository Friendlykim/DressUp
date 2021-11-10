using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl3 : MonoBehaviour
{
    public Transform hairGroup;
    public Transform upperGroup;
    public Transform bodyGroup;
    //private int HairCount;
    //private int UpperCount;
    //private int BodyCount;

    List<GameObject> hairs = new List<GameObject>();
    List<GameObject> uppers = new List<GameObject>();
    List<GameObject> bodys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        MakeDress(hairGroup, hairs);
        MakeDress(upperGroup, uppers);
        MakeDress(bodyGroup, bodys);

        SetDress(hairs, 0);
        SetDress(uppers, 0);
        SetDress(bodys, 0);

        //HairCount = 0;
        //UpperCount = 0;
        //BodyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetDress(hairs, 0);
            SetDress(uppers, 0);
            SetDress(bodys, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetDress(hairs, 1);
            SetDress(uppers, 1);
            SetDress(bodys, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetDress(hairs, 2);
            SetDress(uppers, 2);
            SetDress(bodys, 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetDress(hairs, 3);
            SetDress(uppers, 3);
            SetDress(bodys, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetDress(hairs, 4);
            SetDress(uppers, 4);
            SetDress(bodys, 4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SetDress(hairs, 5);
            SetDress(uppers, 5);
            SetDress(bodys, 5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SetDress(hairs, 6);
            SetDress(uppers, 6);
            SetDress(bodys, 6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SetDress(hairs, 7);
            SetDress(uppers, 7);
            SetDress(bodys, 7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SetDress(hairs, 8);
            SetDress(uppers, 8);
            SetDress(bodys, 8);
        }
    }
    void MakeDress(Transform group, List<GameObject> list)
    {
        foreach (Transform dress in group)
        {
            dress.gameObject.SetActive(false);
            list.Add(dress.gameObject);
        }
        list[0].SetActive(true);
    }
    void SetDress(List<GameObject> list, int n)
    {
        for (int i = 0; i < list.Count; i++)
            list[i].SetActive(false);
        list[n].SetActive(true);
    }
}

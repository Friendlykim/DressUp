using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl1 : MonoBehaviour
{
    public Transform hairGroup;
    public Transform upperGroup;
    public Transform bodyGroup;

    List<GameObject> hairs = new List<GameObject>();
    List<GameObject> uppers = new List<GameObject>();
    List<GameObject> bodys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {                                        // for : 배열안 모든 오브젝트를 순서없이 모두 가져옴
        foreach(Transform hair in hairGroup) // foreach : 배열(hair)의 모든 오브젝트를 순서대로 가져옴
        {
            hair.gameObject.SetActive(false);
            hairs.Add(hair.gameObject);
        }
        hairs[0].SetActive(true);

        foreach (Transform upper in upperGroup)
        {
            upper.gameObject.SetActive(false);
            uppers.Add(upper.gameObject);
        }
        uppers[0].SetActive(true);

        foreach (Transform body in bodyGroup)
        {
            body.gameObject.SetActive(false);
            bodys.Add(body.gameObject);
        }
        bodys[0].SetActive(true);

    }

    void SetHair(int n)
    {
        for (int i = 0; i < hairs.Count; i++)
            hairs[i].SetActive(false);
        hairs[n].SetActive(true);
    }

    void SetUpper(int n)
    {
        for (int i = 0; i < uppers.Count; i++)
            uppers[i].SetActive(false);
        uppers[n].SetActive(true);
    }

    void SetBody(int n)
    {
        for (int i = 0; i < bodys.Count; i++)
            bodys[i].SetActive(false);
        bodys[n].SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            SetHair(0);
            SetUpper(0);
            SetBody(0);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SetHair(1);
            SetUpper(1);
            SetBody(1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SetHair(2);
            SetUpper(2);
            SetBody(2);
        }
    }
}

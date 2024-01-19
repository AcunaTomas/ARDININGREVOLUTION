using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptionsSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _Prefab;
    [SerializeField]
    private GameObject _ARObjects;

    void Start()
    {
        _ARObjects = GameObject.Find("MincedBeef");
        for (int i = 0; i < _ARObjects.transform.childCount; i++)
        {
            var a = Instantiate(_Prefab, new Vector3(0,0, 0 ), Quaternion.identity , transform);

            if (_ARObjects.transform.GetChild(i).gameObject.tag == "Food")
            {
                a.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 37.5f - 15 * (i+0));
            }
            else
            {
                a.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 29 - 15 * (i+0));
            }


            a.GetComponent<ListItem>().Init(_ARObjects.transform.GetChild(i));
        }
    }

    void Update()
    {
        
    }
}

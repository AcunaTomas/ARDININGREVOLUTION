using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ah2kart : MonoBehaviour
{
    [SerializeField]
    private OrderMenuLogic OrderMenu;
    [SerializeField]
    private GameObject dish;

    void Start()
    {
        dish = GameObject.Find("MincedBeef");
    }

    public void add2Order()
    {
        for (int i = 0; i < dish.transform.childCount; i++ )
        {
            if (dish.transform.GetChild(i).gameObject.activeSelf)
            {
                OrderMenu.AddListItem(dish.transform.GetChild(i).gameObject.name);
            }
        }

    }
}

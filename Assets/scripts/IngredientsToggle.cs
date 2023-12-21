using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientsToggle : MonoBehaviour
{
    [SerializeField]
    GameObject Dishes;
    [SerializeField]
    TextMeshProUGUI desc;
    
    void Start()
    {
        Dishes = GameObject.Find("MincedBeef");
        
    }

    public void EnableIng()
    {
        for (int i = 0; i < Dishes.transform.childCount; i++)
        {
            if (Dishes.transform.GetChild(i).gameObject.activeSelf == true && Dishes.transform.GetChild(i).GetChild(0).gameObject.activeSelf == false && Dishes.transform.GetChild(i).gameObject.tag != "Drinks")
            {
                Dishes.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);
                print('a');
            }
            else
            {
                Dishes.transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
                print('b');
            }
        } 
    }

}

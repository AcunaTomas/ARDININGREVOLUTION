using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderMenuLogic : MonoBehaviour
{
    
    public float objlimit = 4;
    [SerializeField]
    private GameObject listT;
    public void AddListItem(string a)
    {
        bool change = true;
        for (int i = 0; i < 4; i++)
        {
            if (listT.transform.GetChild(i).gameObject.activeSelf || listT.transform.GetChild(i).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text == a)
            {

            }
            else
            {
                if(change)
                {
                    listT.transform.GetChild(i).gameObject.SetActive(true);
                    listT.transform.GetChild(i).gameObject.name = a;
                    listT.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = a;
                    change = false;
                }

            }

        }

    }
}

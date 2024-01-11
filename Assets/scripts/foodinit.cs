using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodinit : MonoBehaviour
{
    
    void Start()
    {
        GameObject list = GameObject.Find("MincedBeef");
        print(ScenePersistentData.frepabname);
        if (ScenePersistentData.frepabname != " ")
        {
            for (int i = 0; i < list.transform.childCount ; i++ )
            {
                if (list.transform.GetChild(i).gameObject.name == ScenePersistentData.frepabname)
                {
                    list.transform.GetChild(i).gameObject.SetActive(true);
                    print(GameObject.Find("Yogurt sample"));
                    GameObject.Find("Yogurt sample").GetComponent<LabelUpdate>().UpdateText(ScenePersistentData.frepabname);
                }
                else
                {
                    list.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            
            return;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

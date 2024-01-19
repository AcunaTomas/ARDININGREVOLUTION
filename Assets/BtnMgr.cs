using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnMgr : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OPENMENU()
    {
        SceneManager.LoadScene("DishChooser");
    }
    public void StartAR()
    {
        print("here");
        SceneManager.LoadScene("BlankAR");
        ScenePersistentData.frepabname = gameObject.name;
    }


}

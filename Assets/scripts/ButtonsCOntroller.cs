using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonsCOntroller : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;



    public void PleasOpenTheMenu(bool b)
    {
        menu.SetActive(b);
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("DishChooser");
    }

    public void PleaseRotate()
    {
        if (menu == null)
        {
            menu = GameObject.Find("MincedBeef");
        }
        menu.GetComponent<Rotator>().PlasRot();

    }

    public void OpenTheYTLonk()
    {

        if(menu.GetComponent<TextMeshProUGUI>().text == "Pizza")
        {
            print(ScenePersistentData.url1);
            Application.OpenURL(ScenePersistentData.url1);
        }
        if (menu.GetComponent<TextMeshProUGUI>().text == "Burger")
        {
            print(ScenePersistentData.url2);
            Application.OpenURL(ScenePersistentData.url2);
        }
        if(menu.GetComponent<TextMeshProUGUI>().text == "Capuccinno")
        {
           print(ScenePersistentData.url3);
           Application.OpenURL(ScenePersistentData.url3);
        }
        if(menu.GetComponent<TextMeshProUGUI>().text == "Nuttella Latte")
        {
            print(ScenePersistentData.url4);
            Application.OpenURL(ScenePersistentData.url4);
        }
        if(menu.GetComponent<TextMeshProUGUI>().text == "Soft Drinks")
        {
            print(ScenePersistentData.url5);
            Application.OpenURL(ScenePersistentData.url5);
        }
    }

}

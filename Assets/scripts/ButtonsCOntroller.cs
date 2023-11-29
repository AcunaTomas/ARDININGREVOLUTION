using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("MainMenu");
    }

    public void PleaseRotate()
    {
        menu.transform.Rotate(0,1,0, Space.Self);

    }

}

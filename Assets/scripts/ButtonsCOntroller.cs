using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsCOntroller : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;

    public void PleasOpenTheMenu(bool b)
    {
        menu.SetActive(b);
        
    }

}

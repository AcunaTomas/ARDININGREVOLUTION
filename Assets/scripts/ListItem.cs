using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListItem : MonoBehaviour
{
    private TextMeshProUGUI _sexto;

    [SerializeField]
    private GameObject _ARObj;
    void Start()
    {

    }

    public void Init(Transform a)
    {
        _ARObj = a.gameObject;
        _sexto = gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        _sexto.text = _ARObj.name;
    }

    public void SwitchGlish()
    {
        for (int i = 0; i < _ARObj.transform.parent.childCount; i++)
        {
            _ARObj.transform.parent.GetChild(i).gameObject.SetActive(false);
        }
        _ARObj.SetActive(true);
 
    }
}

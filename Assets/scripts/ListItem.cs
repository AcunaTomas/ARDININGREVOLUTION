using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListItem : MonoBehaviour
{
    private TextMeshProUGUI _sexto;

    [SerializeField]
    private GameObject _ARObj;
    private GameObject label;
    void Start()
    {
        label = GameObject.Find("Yogurt sample");
    }

    public void Init(Transform a)
    {
        _ARObj = a.gameObject;
        _sexto = gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        _sexto.text = _ARObj.name;
        label = GameObject.Find("Yogurt sample");
    }

    public void SwitchGlish()
    {
        for (int i = 0; i < _ARObj.transform.parent.childCount; i++)
        {
            _ARObj.transform.parent.GetChild(i).gameObject.SetActive(false);
        }
        _ARObj.SetActive(true);
        print(_ARObj.name);
        print(label);
        label.GetComponent<LabelUpdate>().UpdateText(_ARObj.name);
        transform.parent.gameObject.SetActive(false);
 
    }
}

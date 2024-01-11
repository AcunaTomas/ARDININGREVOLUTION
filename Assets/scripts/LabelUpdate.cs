using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class LabelUpdate : MonoBehaviour
{
    TextMeshProUGUI text = null;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(string name)
    {
        text.text = name;
    }
}

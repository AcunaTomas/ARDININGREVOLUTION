using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class listitemnumbertext : MonoBehaviour
{
    public int value = 1;
    private TextMeshProUGUI texto;
    private void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    public void plus()
    {
        value += 1;
        texto.text = value.ToString();
    }

    public void minus()
    {
        value -= 1;
        texto.text = value.ToString();
    }

}

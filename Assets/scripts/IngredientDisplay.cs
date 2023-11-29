using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientDisplay : MonoBehaviour
{
    [SerializeField]
    GameObject Ing;
    // Start is called before the first frame update

    // Update is called once per frame


    public void SetText(GameObject Ingredient)
    {
        Ing = Ingredient;
        transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = Ing.name;
        transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = Ing.GetComponent<TextMeshPro>().text;
        transform.GetChild(0).gameObject.SetActive(!transform.GetChild(0).gameObject.activeSelf);

    }
}

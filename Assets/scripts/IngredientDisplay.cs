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
        print(Ing.GetComponent<CalorAndCO2>().calories);
        print(Ing.GetComponent<CalorAndCO2>().co2);
        print(Ing.name);
        transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = Ing.name;
        transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = Ing.GetComponent<TextMeshPro>().text;
        transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "Calories: " + Ing.GetComponent<CalorAndCO2>().calories.ToString() +"g";
        transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().text = "Footprint: " + Ing.GetComponent<CalorAndCO2>().co2.ToString() +"CO2";

        if (Ing.GetComponent<CalorAndCO2>().co2 <= 250)
        {
            transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color32(0,255,0,255);
        }
        else if (Ing.GetComponent<CalorAndCO2>().co2 <= 800)
        {
            transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color32(255,255,0,255);
        }
        else
        {
           transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color32(255,0,0,255); 
        }
        
        if (Ing.GetComponent<CalorAndCO2>().calories <= 400)
        {
            transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color32(0,255,0,255);
        }
        else if (Ing.GetComponent<CalorAndCO2>().calories <= 800)
        {
            transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color32(255,255,0,255);
        }
        else
        {
           transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color32(255,0,0,255); 
        }

        transform.GetChild(0).gameObject.SetActive(!transform.GetChild(0).gameObject.activeSelf);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class what : MonoBehaviour
{
     public GameObject r;
    // Start is called before the first frame update
    void Start()
    {
        r = GameObject.Find("Test");
        r.GetComponent<TextMeshProUGUI>().text = "Spawned";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class ScanTest : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject thingtospawn;
    Camera ARcam;
    GameObject instanceofThingtoSpawn;


    void Awake()
    {
        instanceofThingtoSpawn = null;
        ARcam = GameObject.Find("AR Camera").GetComponent<Camera>();

    }



    void Update()
    {
        if (Input.touchCount == 0)
            return;

        RaycastHit hit;
        Ray ray = ARcam.ScreenPointToRay(Input.GetTouch(0).position);
        if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_hits))
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && instanceofThingtoSpawn == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Spawnable")
                    {
                        instanceofThingtoSpawn = hit.collider.gameObject;
                    }
                    else
                    {
                        SpawnPrefab(m_hits[0].pose.position);
                    }
                }
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Ingredient")
                    {
                        GameObject.Find("Yogurt sample").GetComponent<TextMeshProUGUI>().text = hit.collider.gameObject.name;
                    }
                    else
                    {
                        
                    }
                }
            }

        }

        if (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
        {
            if (Input.GetTouch(0).deltaPosition.y > 0 && Input.GetTouch(1).deltaPosition.y < 0)
            {
                instanceofThingtoSpawn.transform.localScale += new Vector3(0.01f,0.01f,0.01f);
                if ( instanceofThingtoSpawn.transform.localScale.x >= 3)
                {
                    instanceofThingtoSpawn.transform.localScale = new Vector3(2f,2f,2f); 
                } 
            }
            else
            {
                instanceofThingtoSpawn.transform.localScale -= new Vector3(0.01f,0.01f,0.01f); 
                if (instanceofThingtoSpawn.transform.localScale.x <= 0.1)
                {
                    instanceofThingtoSpawn.transform.localScale = new Vector3(0.01f,0.01f,0.01f);  
                } 
            } 
        }

 

    }

    private void SpawnPrefab(Vector3 spawnPosition)
    {
        instanceofThingtoSpawn = Instantiate(thingtospawn, spawnPosition, Quaternion.identity);
    }
}

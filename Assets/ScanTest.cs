using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class ScanTest : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject thingtospawn;
    [SerializeField]
    GameObject thingtospawn2;
    [SerializeField]
    GameObject ArPlaneMgr;
    Camera ARcam;
    GameObject instanceofThingtoSpawn;
    float staleDist = 0;
    int LayerIgnoreRaycast;
    void Awake()
    {
        instanceofThingtoSpawn = null;
        ARcam = GameObject.Find("AR Camera").GetComponent<Camera>();
        LayerIgnoreRaycast =  LayerMask.NameToLayer("Ignore Raycast");
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
                        Destroy(GameObject.Find("Canvas"));
                        SpawnPrefab(m_hits[0].pose.position);
                        ArPlaneMgr.GetComponent<ARPlaneManager>().enabled = false;
                        GameObject[] a = GameObject.FindGameObjectsWithTag("Plane");

                        foreach (GameObject ca in a )
                        {
                            ca.GetComponent<LineRenderer>().enabled = false;
                            ca.GetComponent<MeshRenderer>().enabled = false;
                            ca.GetComponent<ARPlaneMeshVisualizer>().enabled = false;
                            ca.layer = LayerIgnoreRaycast;
                        }

                    }
                    
                }
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount == 1)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    print(hit.collider.gameObject.tag);
                    if (hit.collider.gameObject.tag == "Ingredient")
                    {
                        print("Got Before the find");
                        print(GameObject.FindWithTag("IF"));
                        GameObject.FindWithTag("IF").GetComponent<IngredientDisplay>().SetText(hit.collider.gameObject);
                        print("Got Here");
                    }

                }
            }

        }



        if (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved )
        {        
            if (Input.GetTouch(0).position.y > Input.GetTouch(1).position.y )
            {
                if (Input.GetTouch(0).deltaPosition.y > 0)
                {
                    instanceofThingtoSpawn.transform.localScale += new Vector3(0.03f,0.03f,0.03f);
                    if ( instanceofThingtoSpawn.transform.localScale.x >= 3)
                    {
                        instanceofThingtoSpawn.transform.localScale = new Vector3(2f,2f,2f); 
                    } 
                }
                else
                {
                    instanceofThingtoSpawn.transform.localScale -= new Vector3(0.03f,0.03f,0.03f); 
                    if (instanceofThingtoSpawn.transform.localScale.x <= 0.1)
                    {
                        instanceofThingtoSpawn.transform.localScale = new Vector3(0.01f,0.01f,0.01f);  
                    } 
                }

            }
            else if (Input.GetTouch(0).position.y < Input.GetTouch(1).position.y)
            {
                if (Input.GetTouch(1).deltaPosition.y > 0)
                {
                    instanceofThingtoSpawn.transform.localScale += new Vector3(0.03f,0.03f,0.03f);
                    if ( instanceofThingtoSpawn.transform.localScale.x >= 3)
                    {
                        instanceofThingtoSpawn.transform.localScale = new Vector3(2f,2f,2f); 
                    } 
                }
                else
                {
                    instanceofThingtoSpawn.transform.localScale -= new Vector3(0.03f,0.03f,0.03f); 
                    if (instanceofThingtoSpawn.transform.localScale.x <= 0.01)
                    {
                        instanceofThingtoSpawn.transform.localScale = new Vector3(0.01f,0.01f,0.01f);  
                    } 
                }
            }
        }
        

 

    }

    private void SpawnPrefab(Vector3 spawnPosition)
    {
        instanceofThingtoSpawn = Instantiate(thingtospawn, spawnPosition, Quaternion.identity);
        Instantiate(thingtospawn2, spawnPosition, Quaternion.identity);
    }
}

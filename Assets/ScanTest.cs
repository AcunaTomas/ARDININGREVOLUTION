using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ScanTest : MonoBehaviour
{
    private ARTrackedImageManager a;
    public GameObject b;

    void Awake()
    {
        a = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        a.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        a.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        //Instantiate(b);

    }

    void Update()
    {
        
    }
}

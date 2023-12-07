using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private bool canISpin = false;

    void FixedUpdate()
    {
        if (canISpin)
        {
            transform.Rotate(0,0.1f,0, Space.Self);
        }    
    }

    public void PlasRot()
    {
        canISpin = !canISpin;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatOri : MonoBehaviour
{
    public Transform orientation;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = orientation.rotation;
    }
}

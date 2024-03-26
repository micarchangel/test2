using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using UnityEngine;

public class MovableObject : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector2.up * Time.deltaTime);
    }
}

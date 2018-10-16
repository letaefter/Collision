using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindingScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    float rotationSpeed = 20f;
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}

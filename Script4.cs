using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("posición: " + gameObject.GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
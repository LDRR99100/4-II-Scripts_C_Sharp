using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubo_rojo = GameObject.FindWithTag("red_cube");
        GameObject cilindro_amarillo = GameObject.FindWithTag("yellow_cylinder");
        Debug.Log("El cubo esta a una distancia de: " + Vector3.Distance(gameObject.GetComponent<Transform>().position, cubo_rojo.GetComponent<Transform>().position));
        Debug.Log("El cilindro esta a una distancia de: " + Vector3.Distance(gameObject.GetComponent<Transform>().position, cilindro_amarillo.GetComponent<Transform>().position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

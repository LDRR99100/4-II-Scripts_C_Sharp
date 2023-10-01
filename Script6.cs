using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubo_rojo = GameObject.FindWithTag("red_cube");
        GameObject cilindro_amarillo = GameObject.FindWithTag("yellow_cylinder");
        cubo_rojo.transform.position = new Vector3(gameObject.GetComponent<Transform>().position[0] + 5, cubo_rojo.transform.position[1], gameObject.GetComponent<Transform>().position[2]);
        cilindro_amarillo.transform.position = new Vector3(gameObject.GetComponent<Transform>().position[0] - 5, cilindro_amarillo.transform.position[1], gameObject.GetComponent<Transform>().position[2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

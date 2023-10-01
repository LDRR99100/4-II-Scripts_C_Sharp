using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cilindro_amarillo = GameObject.FindWithTag("yellow_cylinder");
        if(Input.GetKeyDown(KeyCode.A)) {
            gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            cilindro_amarillo.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}

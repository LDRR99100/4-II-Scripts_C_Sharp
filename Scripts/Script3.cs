using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{   
    public Vector3 vector1;
    public Vector3 vector2;    
    // Start is called before the first frame update
    void Start()
    {
        vector1 = new Vector3(2, 3, 4);
        vector2 = new Vector3(3, 7, 25);
        Debug.Log("Magnitud Vector 1: " + vector1.magnitude);
        Debug.Log("Magnitud Vector 2: " + vector2.magnitude);
        Debug.Log("Angulo que forman: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vector1, vector2));
        if(vector1[1] > vector2[1]) {
            Debug.Log("El Vector 1 esta a una altura mayor");
        }   else if(vector2[1] > vector1[1]) {
                Debug.Log("El Vector 2 esta a una altura mayor");
                }   else {
                    Debug.Log("Los vectores estan a la misma altura");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

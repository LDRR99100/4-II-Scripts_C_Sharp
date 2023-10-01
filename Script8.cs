using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Script8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] second_group;
        float[] distances = new float[3];
        second_group = GameObject.FindGameObjectsWithTag("second_group");

        for (int i = 0; i < 3; i++) {
            distances[i] = Vector3.Distance(gameObject.GetComponent<Transform>().position, second_group[i].GetComponent<Transform>().position);
        }
        float minValue = distances.Min();
        int minIndex = distances.ToList().IndexOf(minValue);
        second_group[minIndex].transform.position = new Vector3(second_group[minIndex].transform.position[0], second_group[minIndex].transform.position[1] + 5, second_group[minIndex].transform.position[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject[] second_group;
        float[] distances = new float[3];
        second_group = GameObject.FindGameObjectsWithTag("second_group");

        for (int i = 0; i < 3; i++) {
            distances[i] = Vector3.Distance(gameObject.GetComponent<Transform>().position, second_group[i].GetComponent<Transform>().position);
        }
        float maxValue = distances.Max();
        int maxIndex = distances.ToList().IndexOf(maxValue);

        if (Input.GetKeyDown(KeyCode.Space)) {
            second_group[maxIndex].GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
        
    }
    
}

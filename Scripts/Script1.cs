using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
        public int[] randomArray = new int[25];

    // Start is called before the first frame update
    void Start()
    {
          for (int i = 0; i < 25; i++) {
            randomArray[i] = UnityEngine.Random.Range(0, 25);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        int randNumber = UnityEngine.Random.Range(0,24);
        if(randomArray[randNumber] > 15) {
            Debug.Log(randomArray[randNumber]);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public string examplePublicVariable = "Example";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == 1)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Debug.Log("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Debug.Log("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Debug.Log("Buzz");
                }
                else
                {
                    Debug.Log(i);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int start;
    public int amount;

    private int activationFrame;

    // Start is called before the first frame update
    void Start()
    {
        start = Random.Range(1, 11);  
        amount = Random.Range(1, 11);

        activationFrame = Time.frameCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == activationFrame)
        {
            for (int i = 0; i <= amount; i++)
            {
                Debug.Log(start + i);
            }
        }
    }
}

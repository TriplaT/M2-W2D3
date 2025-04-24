using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    private int[] numbers = new int[4];
    private int iterationCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 101);
        }
        int sum = 0;
        int product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];
            iterationCount++;

            Debug.Log("Iteration " + iterationCount + ": Sum = " + sum + ", Product = " + product);

            if (iterationCount == 2)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


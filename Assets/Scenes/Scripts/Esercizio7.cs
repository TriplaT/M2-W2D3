using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    private int[] myArray;

    // Start is called before the first frame update
    void Start()
    {
        myArray = new int[20];

        GeneraArray(myArray, 1, 100);
        StampaArray(myArray);

        int sum = SommaArray(myArray);
        Debug.Log("Sum of array elements: " + sum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GeneraArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max + 1); 
        }
    }

    int SommaArray(int[] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return sum;
    }

    void StampaArray(int[] array)
    {
        string output = "Array elements: ";
        foreach (int value in array)
        {
            output += value + " ";
        }
        Debug.Log(output);
    }
}

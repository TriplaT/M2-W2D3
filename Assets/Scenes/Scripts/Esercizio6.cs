using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    private int[] myArray;

    // Start is called before the first frame update
    void Start()
    {
        myArray = GeneraArray();
        StampaArray(myArray);

        int sum = SommaArray(myArray);
        Debug.Log("Sum of array elements: " + sum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int[] GeneraArray()
    {
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 101);
        }
        return array;
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
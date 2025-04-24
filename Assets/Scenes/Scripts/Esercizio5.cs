using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int find = 5;
    private int[] numbers;
    private int arraySize = 10;
    // Start is called before the first frame update
    void Start()
    {
        numbers = new int[arraySize];
        System.Random rand = new System.Random();

        int findIndex = rand.Next(arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            if (i == findIndex)
            {
                numbers[i] = find;
            }
            else
            {
                int randomNum;
                do
                {
                    randomNum = rand.Next(0, 11);
                } while (randomNum == find);
                numbers[i] = randomNum;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == find)
            {
                Debug.Log("FOUND!!!!");
            }
            else
            {
                Debug.Log("NOT FOUND!!!!");
            }
        }
        Debug.Log("ITERATION FINISHED - Frame: " + Time.frameCount);
    }
}

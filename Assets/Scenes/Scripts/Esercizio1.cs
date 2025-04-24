using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int index;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        index = 10;
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        while (index > 0)
        {
            num++;
            Debug.Log(num);
            index--;

            if (index == 0)
            {
                break;
            }
        }
    }
}
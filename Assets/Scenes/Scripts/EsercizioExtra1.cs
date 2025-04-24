using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsercizioExtra1 : MonoBehaviour
{
    private int[] TabellinaTre;
    // Start is called before the first frame update
    void Start()
    {
        TabellinaTre = new int[10];
        for (int i = 0; i < 10; i++)
        {
            TabellinaTre[i] = 3 * (i + 1);
        }
        PrintTabellina(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintTabellina(int index)
    {
        if (index >= TabellinaTre.Length)
        {
            return;
        }
        Debug.Log("3 x " + (index + 1) + " = " + TabellinaTre[index]);
        PrintTabellina(index + 1);
    }
}

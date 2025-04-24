using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsercizioExtra2 : MonoBehaviour
{
    private int[] Tabelline;
    // Start is called before the first frame update
    void Start()
    {
        Tabelline = new int[12 * 10];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Tabelline[i * 10 + j] = (i + 1) * (j + 1);
            }
        }
        StampaTabelline(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StampaTabelline(int index)
    {
        if (index >= Tabelline.Length)
        {
            return;
        }

        int tabellina = index / 10 + 1;
        int moltiplicatore = index % 10 + 1;

        Debug.Log(tabellina + " x " + moltiplicatore + " = " + Tabelline[index]);
        StampaTabelline(index + 1);
    }
}

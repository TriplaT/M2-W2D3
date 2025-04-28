using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsercizioExtra4 : MonoBehaviour
{
    public int n = 1;
    public int m = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int num = n; num <= m; num++)
        {
            Debug.Log("Tabellina del " + num + " :");
            for (int i = 1; i <= 10; i++)
            {
                Debug.Log(num + " x " + i + " = " + (num * i));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

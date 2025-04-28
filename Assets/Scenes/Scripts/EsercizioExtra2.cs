using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsercizioExtra2 : MonoBehaviour
{
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tabellina del " + n + " : ");
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(n + " x " + i + " = " + (n* i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

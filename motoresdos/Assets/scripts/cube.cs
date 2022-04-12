using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    void Start()
    {
        GenerarForma();
    }

    public void GenerarForma()
    {
        GetComponent<Renderer>().sharedMaterial.forma = Random.
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.forma = Forma.cube;
    }
}

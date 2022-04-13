using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    void Start()
    {
        GenerarColor();
    }

    public void GenerarColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}

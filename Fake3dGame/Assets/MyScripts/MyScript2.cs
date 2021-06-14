using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript2 : MonoBehaviour
{
    public Color color;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Renderer rend = GetComponent<Renderer>();
        Material material = rend.material;
        material.color = color;
    }
}

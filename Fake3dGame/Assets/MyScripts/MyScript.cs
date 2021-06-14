using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public Color color;
    public Renderer renderer;
    void Start()
    {
        renderer.material.color = Color.blue;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        renderer.material.color = color;
    }
}

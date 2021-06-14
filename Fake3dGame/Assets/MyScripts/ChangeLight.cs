using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    Renderer rend;
    Light l;
    public Color color;

    void Start()
    {
        rend = GetComponent<Renderer>();
        l = rend.GetComponent<Light>();
        l.color = Color.red;
        color = l.color;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rend = GetComponent<Renderer>();
        l = rend.GetComponent<Light>();
        l.color = Color.blue;
        color = l.color;
    }
}

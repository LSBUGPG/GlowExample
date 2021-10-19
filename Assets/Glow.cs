using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Glow : MonoBehaviour
{
    new public Renderer renderer;
    public Color colour;
    public float bloom;
    public float speed = 1.0f;
    float time = 0.0f;
    Material material;

    void Start()
    {
        material = renderer.material;
        renderer.material = material;
    }

    void Update()
    {
        time += Time.deltaTime * speed;
        float pulse = Mathf.Sin(time) * 0.5f + 0.5f;
        colour.r = pulse * bloom;
        material.SetColor("_EmissionColor", colour);
    }
}

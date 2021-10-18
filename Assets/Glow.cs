using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Glow : MonoBehaviour
{
    public PostProcessVolume volume;
    public float bloom;
    public float speed = 1.0f;
    float time = 0.0f;

    void Update()
    {
        time += Time.deltaTime * speed;
        PostProcessProfile profile = volume.profile;
        Bloom bloomEffect = profile.GetSetting<Bloom>();
        float pulse = Mathf.Sin(time) * 0.5f + 0.5f;
        bloomEffect.intensity.Override(pulse * bloom);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChairEvents : MonoBehaviour
{
    float entered = -1F;
    bool has_entered = false;
    bool isFalen = false;
    public Rigidbody rb;
    public Sound sound;

    void Awake()
    {
        sound.source = gameObject.AddComponent<AudioSource>();
        sound.source.clip = sound.clip;
        sound.source.volume = sound.volume;
        sound.source.pitch = sound.pitch;
        sound.source.time = 0.1f;
    }

    public void enter()
    {
        has_entered = true;
        entered = Time.time;
        Debug.Log("Entered");
    }

    public void exit()
    {
        has_entered = false;
        Debug.Log("Exited");
    }

    void FixedUpdate()
    {
        if (!isFalen && has_entered && Time.time - entered > 1.5)
        {
            Debug.Log(entered);
            Debug.Log(Time.time);
            sound.source.Play();
            isFalen = true;
            rb.velocity = transform.forward * 3;
        }
    }
}

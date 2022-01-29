using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookshelfEvents : MonoBehaviour
{
    float entered = -1F;
    bool has_entered = false;
    public Sound sound;

    void Awake()
    {
        sound.source = gameObject.AddComponent<AudioSource>();
        sound.source.clip = sound.clip;
        sound.source.volume = sound.volume;
        sound.source.pitch = sound.pitch;
        sound.source.time = 0.6f;
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

    void Update()
    {
        if (has_entered && Time.time - entered > 1.5)
        {
            Debug.Log(entered);
            Debug.Log(Time.time);
            Color color = GetComponent<Renderer>().material.color;
            if (color == Color.yellow)
            {
                color = Color.white;
            }
            else if (color == Color.white)
            {
                color = new Color(14f / 255f, 48f / 255f, 15f / 255f);
            }
            else
            {
                color = Color.yellow;
            }
            sound.source.Play();
            GetComponent<Renderer>().material.color = color;
            entered = Time.time;
        }
    }
}

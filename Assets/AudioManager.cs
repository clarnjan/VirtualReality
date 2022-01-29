using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound backgroundMusic;

    void Awake()
    {
        backgroundMusic.source = gameObject.AddComponent<AudioSource>();
        backgroundMusic.source.clip = backgroundMusic.clip;
        backgroundMusic.source.volume = backgroundMusic.volume;
        backgroundMusic.source.pitch = backgroundMusic.pitch;
    }

    // Update is called once per frame
    void Start()
    {
        backgroundMusic.source.Play();
    }
}

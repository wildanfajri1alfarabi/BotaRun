using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;

    public string name;
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;
    public bool loop; 
}

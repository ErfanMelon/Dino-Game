using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioClip soundClip; // Assign the sound clip in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        PlaySound();
    }

    void PlaySound()
    {
        audioSource.PlayOneShot(soundClip);
    }
}

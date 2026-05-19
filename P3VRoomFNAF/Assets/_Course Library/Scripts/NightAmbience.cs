using UnityEngine;

public class NightAmbience : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void PlayRandomSound()
    {
        if (audioClips.Length == 0) return;

        int index = Random.Range(0, audioClips.Length);

        audioSource.PlayOneShot(audioClips[index]);
    }
}

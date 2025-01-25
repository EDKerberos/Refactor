using UnityEngine;

public class SfxScript : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    public void PlayAudioCLip()
    {
            audioSource.Play();
    }
}

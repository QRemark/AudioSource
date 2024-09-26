using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbiendSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void SetAmbient(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}

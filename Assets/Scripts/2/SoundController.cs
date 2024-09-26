using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundController : MonoBehaviour
{
    

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private float _volume = 0.5f;
    [SerializeField] private Transform _point;
    [SerializeField] private float _delay = 4;
    

    void Start()
    {
        if (Input.GetMouseButtonDown(0))
            _audioSource.Play();
    }

    void Start2()
    {
        if (Input.GetMouseButtonDown(0))
            _audioSource.PlayOneShot(_clip, _volume);
        ///или
        if (Input.GetMouseButtonDown(0))
            _audioSource.PlayOneShot(_audioSource.clip, _volume);
    }

    void Start3()
    {
        AudioSource.PlayClipAtPoint(_clip, _point.transform.position, _volume);
    }

    void Start4()
    {
        _audioSource.PlayDelayed(_delay);
    }
}

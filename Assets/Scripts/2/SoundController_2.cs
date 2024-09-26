using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundController_2 : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Transform _player;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        _audioSource.volume = 0.5f;
        _audioSource.pitch = 1.2f;
        _audioSource.Play();
    }

    private void Start3D()
    {
        _audioSource.spatialBlend = 1; ///звук станет 3д
    }

    private void Update()
    {
        _audioSource.transform.position = _player.position;
    }
}

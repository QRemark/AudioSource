using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundZone : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] private AmbiendSound _ambiendSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<AmbiendListener>() == false)
            return;

        _ambiendSound.SetAmbient(_clip);
    }
}

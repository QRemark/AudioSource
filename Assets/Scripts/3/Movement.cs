using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private FootStepsSounds _stepSounds;
    [SerializeField] private float _stepDistance;

    private float _coverDistance = 0f;

    private void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(_rotationSpeed * rotation * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        float direction = Input.GetAxis("Vertical");

        if (direction == 0f)
        {
            _coverDistance = 0f;
            return;
        }

        float distance = _moveSpeed * direction * Time.deltaTime;
        _coverDistance += Mathf.Abs(distance);
        transform.Translate(distance * Vector3.forward);

        if (_coverDistance >= _stepDistance) 
        {
            _coverDistance -= _stepDistance;
            _stepSounds.Play();
        }
    }
}

using Mirror;
using System.Collections;
using UnityEngine;
[RequireComponent(typeof(CurrentInput))]

public class PlayerMover : NetworkBehaviour, IMovableObject
{
    private Vector3 _rotationVector;
    private CurrentInput _currentInput;

    private float _rotateSpeed = 20.0f;
    private float _movingValue;


    private void Start()
    {
        if (isLocalPlayer)
            _currentInput = GetComponent<CurrentInput>();
    }

    private void Update()
    {
        if (isLocalPlayer)
        {
            _rotationVector = _currentInput.Input.GetMovingVector();
            transform.Rotate(_rotationVector * _rotateSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * _movingValue * Time.deltaTime);

        }
    }
    public void Move()
    {
        if (_movingValue == 1)
            _movingValue = 0;
        else
            _movingValue = 1;
    }
    public void Rotate()
    {
        if (_rotateSpeed == 20)
            _rotateSpeed = 0;
        else
            _rotateSpeed = 20;
    }
}
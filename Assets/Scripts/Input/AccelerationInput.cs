using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationInput : BaseInput
{
    private float _moveSpeed = 20f;
    public override Vector3 GetMovingVector()
    {
        X = Input.acceleration.x * _moveSpeed;
        Y = Input.acceleration.y * _moveSpeed;
        Z = Input.acceleration.z * _moveSpeed;
        return new Vector3(X, Y, Z);
    }
}

using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class BaseInput : NetworkBehaviour, IInput
{
    protected float X;
    protected float Y;
    protected float Z;
    public bool CanRotate { get; set; } = true;
    public bool MoveForward { get; set; }

    protected void Update()
    {
        if (isLocalPlayer && CanRotate)
        { 
            GetMovingVector();
        }

    }
    public virtual Vector3 GetMovingVector()
    {
        return Vector3.zero;
    }
}

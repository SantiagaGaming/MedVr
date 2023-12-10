using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public abstract class BaseMoveCreatableObject : NetworkBehaviour, IMovableObject
{
    protected Vector3 MoveDirection;
    protected float MoveSpeed;
    protected void Update()
    {
        Move();
    }
    public virtual void Move()
    {
        transform.position += MoveDirection * MoveSpeed * Time.deltaTime;
    }

    public void Rotate()
    {
        throw new System.NotImplementedException();
    }
}

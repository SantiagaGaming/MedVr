using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : BaseMoveCreatableObject
{
    private void Start()
    {
        MoveSpeed = 20f;
        MoveDirection = Vector3.forward;
    }
    public override void Move()
    {
        transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);
    }
    public void StopArrow(Transform pos)
    {
        MoveSpeed = 0;
        transform.parent = pos;
    }
}

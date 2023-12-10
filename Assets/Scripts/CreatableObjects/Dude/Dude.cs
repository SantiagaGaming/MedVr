using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dude : BaseCreatableObject
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Arrow arrow))
        {
            arrow.ArrowCollision(transform);
        }
    }
}

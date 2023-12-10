using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCreatableObject : NetworkBehaviour, ICreatableObject
{
    private ObjectsCounter _counter;
    protected virtual void Start()
    {
        _counter = FindObjectOfType<ObjectsCounter>();
        transform.parent = null;
    }
    [ClientRpc]
    public void Destroy()
    {
        _counter.ObjectRemoved(this);
        NetworkServer.Destroy(gameObject);
    }
}

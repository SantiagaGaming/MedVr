using Mirror;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GlobalObjectsHolder : NetworkBehaviour
{
    public delegate void GlobalValueChanged(int value);
    public event GlobalValueChanged GlobalValueChangedEvent;
    [SyncVar]
    private List<BaseCreatableObject> _createbaleObjects;

    [SyncVar]
    [HideInInspector]
    private int _globalObjectsCount;
    private void Start()
    {
        _createbaleObjects = new List<BaseCreatableObject>();
    }
    [ClientRpc]
    public void AddCreatableObject(BaseCreatableObject obj)
    {
        _createbaleObjects.Add(obj);
        UpdateView();
    }
    [ClientRpc]
    public void RemoveCreatableObject(BaseCreatableObject obj)
    {
        _createbaleObjects.Remove(obj);
        UpdateView();
    }
    [ClientRpc]
    public void DestroyAllObjects()
    {
        foreach (var createbleObject in _createbaleObjects)
        {
            if(createbleObject!=null)
                createbleObject.Destroy();
        }
        _createbaleObjects = new List<BaseCreatableObject>();
        UpdateView();
    }
    private void UpdateView()
    {
        var activeObjects = _createbaleObjects.Where(obj => obj!=null).ToList();
        if (activeObjects==null)
        {
            _globalObjectsCount = 0;
            Debug.Log("In If" + activeObjects.Count);
        }
        else
        {
            _globalObjectsCount = activeObjects.Count;
            Debug.Log("In else If " + activeObjects.Count);
        }

        GlobalValueChangedEvent?.Invoke(_globalObjectsCount);
    }

}

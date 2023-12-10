using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCounter : NetworkBehaviour
{
    [SerializeField] private TextView _countText;
    private string _countTextTemp = "Objects count:";
    private GlobalObjectsHolder _objectsHolder;
    private void Start()
    {
        _objectsHolder = FindObjectOfType<GlobalObjectsHolder>();
        _objectsHolder.GlobalValueChangedEvent += OnUpdateView;
    }
    [ClientRpc]
    public void ObjectAdded(BaseCreatableObject obj)
    {
        _objectsHolder.AddCreatableObject(obj);
    }

    [ClientRpc]
    public void ObjectRemoved(BaseCreatableObject obj)
    {
        _objectsHolder.RemoveCreatableObject(obj);
    }
  
    private void OnUpdateView(int value)
    {
        var text = $"{_countTextTemp} {value}";
        _countText.SetText(text);
    }
}

using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class PlayerCreateActions : NetworkBehaviour
{
    [SerializeField] private Dude _dude;
    [SerializeField] private Arrow _arrow;
    [SerializeField] private Transform _arrowPos;
    [SerializeField] private ObjectsCounter _objectsCounter;
    [Command]
    public void CreateDude()
    {
        var networkObj = Instantiate(_dude,RandomizeVector(transform.position), Quaternion.identity);
        NetworkServer.Spawn(networkObj.gameObject);
        _objectsCounter.ObjectAdded(networkObj);
    }
    [Command]
    public void CreateArrow()
    {
        var networkObj = Instantiate(_arrow, _arrowPos);
        NetworkServer.Spawn(networkObj.gameObject);
        _objectsCounter.ObjectAdded(networkObj);
    }
    private Vector3 RandomizeVector(Vector3 pos)
    {
        float rndX = Random.Range(-5, 6);
        float rndZ = Random.Range(-10, 12);
        var randomVector = new Vector3 (pos.x+rndX, pos.y, pos.z+rndZ);
        return randomVector;
    }

}

using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
[RequireComponent(typeof (MoveArrow))]

public class Arrow : BaseCreatableObject
{
    private bool _destroyByTime = true;
    private float _delayTime = 3f;
    private MoveArrow _moveArrow;
    protected override void Start()
    {
        base.Start();
        _moveArrow = GetComponent<MoveArrow>();
        StartCoroutine(DestroyDelay());
    }
    public void ArrowCollision(Transform pos)
    {
        _moveArrow.StopArrow(pos);
        _destroyByTime = false;
    }
   
    private IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(_delayTime);
        if (_destroyByTime)
        {
            Debug.Log("Destroy");
            Destroy();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDude : BaseMoveCreatableObject
{

    private void Start()
    {
        StartCoroutine(RandomizeSpeedAndDirection());
    }
    private IEnumerator RandomizeSpeedAndDirection()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0.2f, 3f));
        MoveSpeed = UnityEngine.Random.Range(1f, 5f);
        RandomVector();
        StartCoroutine(RandomizeSpeedAndDirection());
    }

    private void RandomVector()
    {
        var randomSide = UnityEngine.Random.Range(0, 4);
        switch (randomSide)
        {
            case 0:
                MoveDirection = Vector3.forward;
                break;
            case 1:
                MoveDirection = -Vector3.forward;
                break;
            case 2:
                MoveDirection = Vector3.left;
                break;
            case 3:
                MoveDirection = -Vector3.left;
                break;
        }
    }
}


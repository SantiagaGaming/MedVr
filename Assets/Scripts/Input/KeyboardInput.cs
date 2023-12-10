using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : BaseInput
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    public override Vector3 GetMovingVector()
    {
        X = Input.GetAxis(HORIZONTAL);
        Y = Input.GetAxis(VERTICAL);
        Vector3 move = new Vector3(Y, X, 0);
        return move;
    }
}

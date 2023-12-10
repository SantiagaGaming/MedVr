using UnityEngine;
public interface IInput
{
    public bool CanRotate { get; set; }
    public bool MoveForward { get; set; }
    Vector3 GetMovingVector();
}

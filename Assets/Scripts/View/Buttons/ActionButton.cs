using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ActionButtonState
{
    Move,
    Rotate,
    Dude
}

public class ActionButton : BaseButton
{
    [SerializeField] PlayerMover _mover;
    [SerializeField] PlayerCreateActions _creater;
    [SerializeField] private ActionButtonState _currentState;
    protected override void ButtonClicked()
    {
      switch(_currentState)
        {
            case ActionButtonState.Move:
                _mover.Move();
                break;
            case ActionButtonState.Rotate:
                _mover.Rotate();
                break;
            case ActionButtonState.Dude:
                _creater.CreateDude();
                break;
        }
    }
}

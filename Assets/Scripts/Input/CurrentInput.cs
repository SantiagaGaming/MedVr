using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum InputState
{
    Desktop,
    Mobile
}
public class CurrentInput : MonoBehaviour
{
    [SerializeField] private InputState _currentState;
    [SerializeField] private KeyboardInput _keyboardInput;
    [SerializeField] private AccelerationInput _accelerationInput;
    public IInput Input { get; private set; }
    private void Start()
    {
        if (_currentState == InputState.Desktop)
            Input = _keyboardInput;
        else if (_currentState == InputState.Desktop)
            Input = _accelerationInput;
    }
}

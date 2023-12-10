using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public enum NetworkButtonState
{
    Client,
    Host
}
public class NetworkButton : BaseButton
{
    [SerializeField] private NetworkButtonState _state;
    [SerializeField] private GameObject _canvas;

    public delegate void NetworkButtonClicked(NetworkButtonState state);
    public NetworkButtonClicked ButtonClickedEvent;
    protected override void ButtonClicked()
    {
        _canvas.SetActive(false);
         ButtonClickedEvent?.Invoke(_state);
    }
}

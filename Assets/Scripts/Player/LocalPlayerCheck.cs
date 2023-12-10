using Mirror;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
[RequireComponent(typeof(Camera))]

public class LocalPlayerCheck : NetworkBehaviour
{
    [SerializeField] private GameObject _head;
    private Camera _camera;
    private void Start()
    {
        PlayerCheck();
    }
    private void PlayerCheck()
    {
        _camera = GetComponent<Camera>();
        if (!isLocalPlayer)
        {
            _camera.enabled = false;
            _camera.GetComponentInChildren<Canvas>().enabled = false;
        }
        else _head.SetActive(false);
    }
}

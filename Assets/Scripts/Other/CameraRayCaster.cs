using Mirror;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Camera))]
public class CameraRayCaster : NetworkBehaviour
{
    [SerializeField] private PlayerCreateActions _createActions;

    private GlobalObjectsHolder _globalObjectsHolder;
    private Camera _camera;

    private void Start()
    {
        _camera = GetComponent<Camera>();
        _globalObjectsHolder = FindObjectOfType<GlobalObjectsHolder>();
    }
    private void Update()
    {
        if (!isLocalPlayer)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out Button btn))
                    return;
                if (hit.collider.gameObject.TryGetComponent(out AllObjectsDestroyer destroyer))
                    _globalObjectsHolder.DestroyAllObjects();
            }
            else
            {
                _createActions.CreateArrow();
                Debug.Log("Arrow");
            }
        }
    }
}

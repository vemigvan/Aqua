using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PCInputController
{
    private ServiceManager _serviceManager;
    private Camera cam;
    private bool leftPointerClicked;

    public Action<Vector3, Collider> LeftPointerClickHandler = delegate { };

    public PCInputController(ServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
        cam = Camera.main;
        Time.timeScale = 1;
        _serviceManager = ServiceManager.Instance;
        _serviceManager.UpdateHandler += OnUpdate;
        _serviceManager.FixedUpdateHandler += OnFixedUpdate;
    }

    private void OnUpdate()
    {
        leftPointerClicked = Input.GetButton("Fire1");
    }

    private void OnFixedUpdate()
    {
        if (leftPointerClicked)
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hitInfo, 100))
            {
                LeftPointerClickHandler(hitInfo.point, hitInfo.collider);
            }
        }
    }

    private void OnDestroy()
    {
        _serviceManager.UpdateHandler -= OnUpdate;
        _serviceManager.FixedUpdateHandler -= OnFixedUpdate;
        _serviceManager.DestroyHandler -= OnDestroy;
    }
}

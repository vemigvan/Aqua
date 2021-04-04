using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ServiceManager : MonoBehaviour
{
    #region Singleton
    public static ServiceManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    #endregion

    public PCInputController PCInputController { get; private set; }
    public bool Paused { get; private set; }

    public Action UpdateHandler = delegate{ };
    public Action LateUpdateHandler = delegate{ };
    public Action FixedUpdateHandler = delegate{ };
    public Action DestroyHandler = delegate{ };

    private void Start()
    {
        PCInputController = new PCInputController(this);
    }
    public void Pause()
    {
        Paused = true;
        Time.timeScale = 0;
    } 
    public void UnPause()
    {
        Paused = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Paused)
                UnPause();
            else
                Pause();
        }
        if (Paused)
            return;
        UpdateHandler();
        LateUpdateHandler();
        FixedUpdateHandler();
    }

    private void LateUpdate()
    {
        if (Paused)
            return;
        LateUpdateHandler();
    }

    private void OnDestroy()
    {
        DestroyHandler();
    }
}

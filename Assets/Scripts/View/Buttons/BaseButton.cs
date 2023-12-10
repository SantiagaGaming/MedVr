using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]

public abstract class BaseButton : MonoBehaviour
{
    protected Button Btn;
    protected void Start()
    {
        Btn = GetComponent<Button>();
        Btn.onClick.AddListener(() => { ButtonClicked(); });
    }
    protected abstract void ButtonClicked();
}


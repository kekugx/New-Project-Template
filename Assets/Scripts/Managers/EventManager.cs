using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : BaseManager
{
    public event Action StartEvent;

    public override void AddEvents()
    {
        
    }

    private void Start()
    {
        StartEvent?.Invoke();
    }
}

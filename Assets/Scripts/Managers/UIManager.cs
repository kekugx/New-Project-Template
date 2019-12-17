using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : BaseManager
{
    public override void AddEvents()
    {
        eventManager.StartEvent += OnStart;
    }

    private void OnStart()
    {
        Debug.Log("UIManager init");
    }
}

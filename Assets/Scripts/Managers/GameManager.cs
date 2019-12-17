using UnityEngine;

public class GameManager : BaseManager
{
    public override void AddEvents()
    {
        eventManager.StartEvent += OnStart;
    }

    private static void OnStart()
    {
        Debug.Log("GameManager init");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameManager), typeof(AnimationManager),
     typeof(SpawnManager)), RequireComponent(typeof(EventManager),
     typeof(UIManager), typeof(InputManager))]
public abstract class BaseManager : MonoBehaviour
{
    protected GameManager gameManager;
    protected AnimationManager animationManager;
    protected SpawnManager spawnManager;
    protected EventManager eventManager;
    protected UIManager uiManager;
    protected InputManager inputManager;

    protected virtual void Awake()
    {
        gameManager = GetComponent<GameManager>();
        animationManager = GetComponent<AnimationManager>();
        spawnManager = GetComponent<SpawnManager>();
        eventManager = GetComponent<EventManager>();
        uiManager = GetComponent<UIManager>();
        inputManager = GetComponent<InputManager>();
        AddEvents();
    }

    public abstract void AddEvents();
}
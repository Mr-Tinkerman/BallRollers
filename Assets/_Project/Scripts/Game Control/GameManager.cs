using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public StateMachine stateMachine;

    void Awake()
    {
        #if !UNITY_EDITOR
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        #endif
    }

    #if UNITY_EDITOR
    void OnEnable()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
    }
    #endif
}
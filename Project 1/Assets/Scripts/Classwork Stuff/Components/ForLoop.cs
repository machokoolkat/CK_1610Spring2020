﻿using UnityEngine;

// code from learn unity tutorial on loops
public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number:" + i);
        }
    }
}
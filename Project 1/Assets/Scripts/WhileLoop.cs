﻿using UnityEngine;

// code from learn unity tutorial on loops
public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
    
}

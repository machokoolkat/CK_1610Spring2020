﻿using UnityEngine;

// code from learn unity on loops
public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        }
        while (shouldContinue == true);
    }
}

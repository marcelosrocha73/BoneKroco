using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjetoPool : ItemPool
{
    public static ObjetoPool SharedInstance;


    protected virtual void Awake()
    {
        SharedInstance = this;
    }
}

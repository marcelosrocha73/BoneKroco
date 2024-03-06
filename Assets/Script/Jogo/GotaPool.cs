using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GotaPool : ItemPool
{
    public static GotaPool SharedInstance;
    

    protected override void Awake()
    {
        SharedInstance = this;
    }
}
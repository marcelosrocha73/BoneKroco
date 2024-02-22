using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GotaPool : ItemPool
{
    public static GotaPool SharedInstance; // nomo do titulo do script tem que ser o mesmo nome 


    void Awake()
    {
        SharedInstance = this;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsound : MonoBehaviour
{
    private static backsound bgsound;

     void Awake()
    {
        if(bgsound == null)
        {
            bgsound = this;
            DontDestroyOnLoad(bgsound);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}

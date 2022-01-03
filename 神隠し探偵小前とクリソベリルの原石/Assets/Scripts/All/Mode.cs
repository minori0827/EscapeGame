using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{
    public static Mode instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public int mode = 0;
    // 0 小前 1 猫田 2 二人
    
    public void Omae()
    {
        mode = 0;
    }
    public void Nekoda()
    {
        mode = 1;
    }
    public void Hutari()
    {
        mode = 2;
    }
}

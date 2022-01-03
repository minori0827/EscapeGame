using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCounter : MonoBehaviour
{
    public static CatCounter instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public int catCount = 0;
    
    public void CountUp()
    {
        catCount++;
    }
}

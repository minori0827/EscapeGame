using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public static Talk instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}

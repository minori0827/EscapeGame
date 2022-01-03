using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillow : MonoBehaviour
{
    public void OnClick()
    {
        gameObject.SetActive(false);
    }
    
    public void Back()
    {
        gameObject.SetActive(true);
    }
}

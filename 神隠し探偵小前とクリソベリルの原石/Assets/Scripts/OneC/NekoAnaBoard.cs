using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoAnaBoard : MonoBehaviour
{
    public GameObject Screw1;
    public GameObject Screw2;
    public GameObject Screw3;
    public GameObject Screw4;
    public GameObject NekoAna;
    public GameObject NekoAnaCamera;
    
    public void EraseBoard()
    {
        if (Screw1.activeSelf == true) return;
        if (Screw2.activeSelf == true) return;
        if (Screw3.activeSelf == true) return;
        if (Screw4.activeSelf == true) return;
        gameObject.SetActive(false);
        NekoAna.SetActive(true);
        NekoAnaCamera.GetComponent<SubCamera>().OnBackArrow();
    }
}

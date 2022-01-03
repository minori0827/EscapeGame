using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedCamera : SubCamera
{
    public GameObject Pillow1;
    public GameObject Pillow2;
    public GameObject Pillow3;
    public GameObject Pillow4;
    
    public override void ReturnArrow()
    {
        Pillow1.GetComponent<Pillow>().Back();
        Pillow2.GetComponent<Pillow>().Back();
        Pillow3.GetComponent<Pillow>().Back();
        Pillow4.GetComponent<Pillow>().Back();
    }
}

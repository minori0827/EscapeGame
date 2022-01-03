using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peice : MonoBehaviour
{
    public void PeiceMove()
    {
        bool hitUp = Physics.Raycast(transform.position,Vector3.forward,0.04f);
        bool hitDown = Physics.Raycast(transform.position,Vector3.back,0.04f);
        bool hitRight = Physics.Raycast(transform.position,Vector3.right,0.04f);
        bool hitLeft = Physics.Raycast(transform.position,Vector3.left,0.04f);
        if (!hitUp)
        {
            transform.localPosition += new Vector3(0,0,3f);
        }
        else if (!hitDown)
        {
            transform.localPosition += new Vector3(0,0,-3f);
        }
        else if (!hitRight)
        {
            transform.localPosition += new Vector3(-3f,0,0);
        }
        else if (!hitLeft)
        {
            transform.localPosition += new Vector3(3f,0,0);
        }
        SlidePuzzle.instance.ClearCheck();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TwoCBook : MonoBehaviour
{
    public void OnClick()
    {
        if (Mode.instance.mode == 1)
        {
            Flowchart.BroadcastFungusMessage("BookNekoda");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("TwoCBook");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TwoABook : MonoBehaviour
{
    public void OnClick()
    {
        if (Mode.instance.mode == 1)
        {
            Flowchart.BroadcastFungusMessage("BookNekoda");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("TwoABook");
        }
    }
}

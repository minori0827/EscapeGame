using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NekoAnaOneAB : DoorNekoAna
{
    public bool NekoAnaFlag = false;
    
    public override void NekoAnaOpen()
    {
        if (!NekoAnaFlag)
        {
            Flowchart.BroadcastFungusMessage("nekoAnaFirst");
            NekoAnaFlag = true;
        }
        else
        {
            Flowchart.BroadcastFungusMessage("nekoAnaOneABOpen");
        }
    }
    public override void NekoAnaBack()
    {
        Flowchart.BroadcastFungusMessage("nekoAnaOneABBack");
    }
}

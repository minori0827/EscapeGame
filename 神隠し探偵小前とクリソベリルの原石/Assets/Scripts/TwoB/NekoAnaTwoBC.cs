using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NekoAnaTwoBC : DoorNekoAna
{
    public override void NekoAnaOpen()
    {
        Flowchart.BroadcastFungusMessage("nekoAnaTwoBCOpen");
    }
    public override void NekoAnaBack()
    {
        Flowchart.BroadcastFungusMessage("nekoAnaTwoBCBack");
    }
}

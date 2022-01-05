using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NekoAnaOneCD : DoorNekoAna
{
    public override void NekoAnaOpen()
    {
        Flowchart.BroadcastFungusMessage("nekoAnaOneCDOpen");
    }
    public override void NekoAnaBack()
    {
        Flowchart.BroadcastFungusMessage("nekoAnaOneCDBack");
    }
}

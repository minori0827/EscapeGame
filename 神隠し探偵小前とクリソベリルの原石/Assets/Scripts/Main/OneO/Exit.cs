using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Exit : MonoBehaviour
{
    public bool ExitFlag = false;
    
    public void OnThis()
    {
        if (ExitFlag == true)
        {
            Flowchart.BroadcastFungusMessage("ExitOpen");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("ExitClose");
        }
    }
}

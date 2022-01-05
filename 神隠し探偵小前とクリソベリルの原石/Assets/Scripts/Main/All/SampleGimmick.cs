using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    public void OnClickObj()
    {
        Debug.Log("クリック");
        
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if(Clear == true)
        {
            Debug.Log("解除");
            gameObject.SetActive(false);
        }
    }
}

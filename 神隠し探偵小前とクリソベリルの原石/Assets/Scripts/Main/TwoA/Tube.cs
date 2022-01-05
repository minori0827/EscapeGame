using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            gameObject.SetActive(false);
        }
    }
}

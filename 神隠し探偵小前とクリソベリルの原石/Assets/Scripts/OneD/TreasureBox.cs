using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBox : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public GameObject cover;
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            cover.transform.localRotation = Quaternion.Euler(0,0,135);
            this.GetComponent<Collider>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public GameObject pairScrew;
    public GameObject NekoAnaBoard;
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            gameObject.SetActive(false);
            if (gameObject.activeSelf == false && pairScrew.activeSelf == false)
            {
                ItemBox.instance.UsedItem();
                NekoAnaBoard.GetComponent<NekoAnaBoard>().EraseBoard();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePuzzle : MonoBehaviour
{
    public static SlidePuzzle instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    [SerializeField] Item.Type clearItem;
    
    public Vector3[] Pos;
    public List<GameObject> PieceList = new List<GameObject>();
    public GameObject Pieces;
    public GameObject Piece9;
    
    public void ClearCheck()
    {
        if(PieceList[0].transform.localPosition == Pos[0]
           && PieceList[1].transform.localPosition == Pos[1]
           && PieceList[2].transform.localPosition == Pos[2]
           && PieceList[3].transform.localPosition == Pos[3]
           && PieceList[4].transform.localPosition == Pos[4]
           && PieceList[5].transform.localPosition == Pos[5]
           && PieceList[6].transform.localPosition == Pos[6]
           && PieceList[7].transform.localPosition == Pos[7])
        {
            this.GetComponent<Collider>().enabled = true;
        }
    }
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            Piece9.SetActive(true);
            Invoke("Open",1f);
        }
    }
    
    public void Open()
    {
        this.transform.localPosition = new Vector3(15f,-0.35f,0);
        Pieces.transform.localPosition = new Vector3(15f,-8.35f,0);
    }
}

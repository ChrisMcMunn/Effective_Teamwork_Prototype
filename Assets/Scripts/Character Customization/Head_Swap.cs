using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Head_Swap : MonoBehaviour
{
    public GameObject HeadLeft;
    public GameObject HeadRight;
    public List<Sprite> Head = new List<Sprite>();

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Head[GameManager.instance.HeadIndex];
    }

    public void LeftClick()
    {
        if (GameManager.instance.HeadIndex == 0)
        {
            GameManager.instance.HeadIndex = Head.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[GameManager.instance.HeadIndex];
            Debug.Log(GameManager.instance.HeadIndex);              
        }
        if (GameManager.instance.HeadIndex <= Head.Count - 1)
        {
            GameManager.instance.HeadIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[GameManager.instance.HeadIndex];
            Debug.Log(GameManager.instance.HeadIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (GameManager.instance.HeadIndex < Head.Count)
        {
            GameManager.instance.HeadIndex += 1;
            Debug.Log(GameManager.instance.HeadIndex);
            Debug.Log(Head.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[GameManager.instance.HeadIndex];

        if (GameManager.instance.HeadIndex >= (Head.Count) - 1)
            {
                GameManager.instance.HeadIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[GameManager.instance.HeadIndex];
            Debug.Log(GameManager.instance.HeadIndex);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Head_Swap : MonoBehaviour
{
    public GameObject HeadLeft;
    public GameObject HeadRight;

    public int spriteIndex;
    public List<Sprite> Head = new List<Sprite>();
    void Start()
    {
        spriteIndex = 1;

    }



    public void LeftClick()
    {
        if (spriteIndex == 0)
        {
            spriteIndex = Head.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[spriteIndex];
            Debug.Log(spriteIndex);              
        }
        if (spriteIndex <= Head.Count - 1)
        {
            spriteIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[spriteIndex];
            Debug.Log(spriteIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (spriteIndex < Head.Count)
        {
            spriteIndex += 1;
            Debug.Log(spriteIndex);
            Debug.Log(Head.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[spriteIndex];

        if (spriteIndex >= (Head.Count) - 1)
            {
            spriteIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Head[spriteIndex];
            Debug.Log(spriteIndex);
            }
        }
    }
}

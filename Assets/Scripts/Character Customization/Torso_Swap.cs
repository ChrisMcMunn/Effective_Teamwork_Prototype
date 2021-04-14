using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Torso_Swap : MonoBehaviour
{
    public GameObject TorsoLeft;
    public GameObject TorsoRight;

    public int spriteIndex;
    public List<Sprite> Torso = new List<Sprite>();

    void Start()
    {
        spriteIndex = 1;

    }



    public void LeftClick()
    {
        if (spriteIndex == 0)
        {
            spriteIndex = Torso.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[spriteIndex];
            Debug.Log(spriteIndex);              
        }
        if (spriteIndex <= Torso.Count - 1)
        {
            spriteIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[spriteIndex];
            Debug.Log(spriteIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (spriteIndex < Torso.Count)
        {
            spriteIndex += 1;
            Debug.Log(spriteIndex);
            Debug.Log(Torso.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[spriteIndex];

        if (spriteIndex >= (Torso.Count) - 1)
            {
            spriteIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[spriteIndex];
            Debug.Log(spriteIndex);
            }
        }
    }
}

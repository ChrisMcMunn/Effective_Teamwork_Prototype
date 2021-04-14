using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Leg_Swap : MonoBehaviour
{
    public GameObject LegLeft;
    public GameObject LegRight;

    public int spriteIndex;
    public List<Sprite> Leg = new List<Sprite>();

    void Start()
    {
        spriteIndex = 1;

    }



    public void LeftClick()
    {
        if (spriteIndex == 0)
        {
            spriteIndex = Leg.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[spriteIndex];
            Debug.Log(spriteIndex);              
        }
        if (spriteIndex <= Leg.Count - 1)
        {
            spriteIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[spriteIndex];
            Debug.Log(spriteIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (spriteIndex < Leg.Count)
        {
            spriteIndex += 1;
            Debug.Log(spriteIndex);
            Debug.Log(Leg.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[spriteIndex];

        if (spriteIndex >= (Leg.Count) - 1)
            {
            spriteIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[spriteIndex];
            Debug.Log(spriteIndex);
            }
        }
    }
}

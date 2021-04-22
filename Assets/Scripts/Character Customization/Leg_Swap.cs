using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Leg_Swap : MonoBehaviour
{
    public GameObject LegLeft;
    public GameObject LegRight;
    public List<Sprite> Leg = new List<Sprite>();


    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Leg[GameManager.instance.LegIndex];
    }

    public void LeftClick()
    {
        if (GameManager.instance.LegIndex == 0)
        {
            GameManager.instance.LegIndex = Leg.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[GameManager.instance.LegIndex];
            Debug.Log(GameManager.instance.LegIndex);              
        }
        if (GameManager.instance.LegIndex <= Leg.Count - 1)
        {
            GameManager.instance.LegIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[GameManager.instance.LegIndex];
            Debug.Log(GameManager.instance.LegIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (GameManager.instance.LegIndex < Leg.Count)
        {
            GameManager.instance.LegIndex += 1;
            Debug.Log(GameManager.instance.LegIndex);
            Debug.Log(Leg.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[GameManager.instance.LegIndex];

        if (GameManager.instance.LegIndex >= (Leg.Count) - 1)
            {
                GameManager.instance.LegIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Leg[GameManager.instance.LegIndex];
            Debug.Log(GameManager.instance.LegIndex);
            }
        }
    }
}

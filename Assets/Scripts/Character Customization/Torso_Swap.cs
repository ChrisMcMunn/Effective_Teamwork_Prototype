using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Torso_Swap : MonoBehaviour
{
    public GameObject TorsoLeft;
    public GameObject TorsoRight;
    public List<Sprite> Torso = new List<Sprite>();


    public void LeftClick()
    {
        if (GameManager.instance.TorsoIndex == 0)
        {
            GameManager.instance.TorsoIndex = Torso.Count - 1;                
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[GameManager.instance.TorsoIndex];
            Debug.Log(GameManager.instance.TorsoIndex);              
        }
        if (GameManager.instance.TorsoIndex <= Torso.Count - 1)
        {
            GameManager.instance.TorsoIndex -= 1;            
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[GameManager.instance.TorsoIndex];
            Debug.Log(GameManager.instance.TorsoIndex);

           
        }
        

    }

    public void RightClick()
    {
        if (GameManager.instance.TorsoIndex < Torso.Count)
        {
            GameManager.instance.TorsoIndex += 1;
            Debug.Log(GameManager.instance.TorsoIndex);
            Debug.Log(Torso.Count);
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[GameManager.instance.TorsoIndex];

        if (GameManager.instance.TorsoIndex >= (Torso.Count) - 1)
            {
                GameManager.instance.TorsoIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = Torso[GameManager.instance.TorsoIndex];
            Debug.Log(GameManager.instance.TorsoIndex);
            }
        }
    }
}

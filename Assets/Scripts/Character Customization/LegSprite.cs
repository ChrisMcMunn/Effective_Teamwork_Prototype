using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegSprite : MonoBehaviour
{
    public List<Sprite> leg = new List<Sprite>();

    void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = leg[GameManager.instance.LegIndex];
    }

}

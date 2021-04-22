using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSprite : MonoBehaviour
{
    public List<Sprite> head = new List<Sprite>();

    void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = head[GameManager.instance.HeadIndex];
    }

}

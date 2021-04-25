using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoSprite : MonoBehaviour
{
    public List<Sprite> torso = new List<Sprite>();

    void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = torso[GameManager.instance.TorsoIndex];
    }

}
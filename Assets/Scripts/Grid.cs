
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int width;
    public int height;
    public int[,] grid;
    public GameObject GridSpace;
    private GameObject GridManager;
    public List<Sprite> piece = new List<Sprite>();
    void Start()
    {
        

        grid = new int[width, height];

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
                    {

                Vector2 offset = new Vector2(j,i);
                    GridSpace.GetComponent<SpriteRenderer>().sprite = piece[Random.Range(0,5)];
                        GameObject GridManager = Instantiate(GridSpace, offset, Quaternion.identity) as GameObject;
                        GridManager.transform.parent = this.transform;
                            GridManager.name = ("(" + i + "," + j + ")");
                       
                        
        }
           
        }
        
    }

        
}

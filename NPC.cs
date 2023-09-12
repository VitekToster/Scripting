using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC HP
    public int health = 1;
    //NPC Lvl
    public int level = 2;
    //NPC Speed
    public float speed = 1.5f;
    //NPC Pos
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Lvl + HP
        health += level;
        print("HP:" + health);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}

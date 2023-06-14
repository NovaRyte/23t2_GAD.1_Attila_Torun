using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    //need player character to attack when we press the spacebar...
    //but first lets it to add a level
    //Variables go here
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;

    //Methods go here

    // Start is called before the first frame update
    void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Attila has hit the spacebar on his keyboard at the front of the room!");
            level++;
        }

        if(level == 5)
        {
            Debug.Log("YOU WIN");
        }
    }
    private void StartTheGameAgainFromLevelOne()
    {
        attack = 10;
        health = 100;
        level = 1;
    }
}

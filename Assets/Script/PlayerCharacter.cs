using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
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

}

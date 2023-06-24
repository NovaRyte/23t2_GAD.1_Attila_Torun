using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // need player character to attack when spacebar is pressed
    //but first add a level
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    [SerializeField] private int experience = 0;
    [SerializeField] private double exptolevelup = 50;

    public TMP_Text combatLog;
    //methods go here

    //start is called before the first frame update
    private void Start()
    {
        combatLog.text = "Beriet, KAMPFE!";
    }


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You Attack!");
            Debug.Log("Attack: " + Mathf.Round((float)attack * 100) / 100);

        }
        if(experience >= exptolevelup)
        {
            LevelUp();
        }
        if (level == 5)
        {
            combatLog.text = "You Win!";
            Debug.Log("You Win!");
        }
    }

    private void LevelUp()
    {
        attack = (int)(attack * 1.225);
        level++;
        exptolevelup *= 1.45;
        combatLog.text = "You Leveled Up!";
        Debug.Log("You Leveled Up!");
    }
}

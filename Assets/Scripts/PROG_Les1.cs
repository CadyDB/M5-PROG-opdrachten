using System;
using UnityEngine;

 class PROG_Les1 : MonoBehaviour
{
    int HP = 100;
    void Start()
    {
        string Naam = "Cady";
        int Score = 1000;
        bool Alive = true;
        

        Debug.Log("Naam: " + Naam);
        Debug.Log("Score: " + Score);
        Debug.Log("Alive: " + Alive);
        Debug.Log("Health: " + HP);
        
        if (HP < 0)
        {
            Debug.Log("You have died.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Health: " + HP);
            HP = HP - 35;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            HP = HP - 80;
        }

        
    }
}

using System;
using UnityEngine;

 class PROG_Les1 : MonoBehaviour
{
    int HP = 100;
    void Start()
    {
        int resultaat = Max(60, 40);
        Debug.Log(resultaat);

        string Naam = "Cady";
        //int Score = 1000;
        //bool Alive = true;
        

        Begroet(Naam);

        //Debug.Log("Naam: " + Naam);
        //Debug.Log("Score: " + Score);
        //Debug.Log("Alive: " + Alive);
        //Debug.Log("Health: " + HP);
        
        if (HP < 0)
        {
            Debug.Log("You have died.");
        }
        
    }
  int Max(int a, int b)
    {
        int hoogste = Mathf.Max(a, b);
        return hoogste;
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

   

    void Begroet(string Naam)
    {
        Debug.Log("Welkom " + Naam);
    }

   
}

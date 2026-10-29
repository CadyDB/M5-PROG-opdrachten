using System;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static event Action<int> ScoreAdded; //Definitie van een Action Event met int als argument
    private int scoreValue = 50;
    void Update()
    {
        
            ScoreAdded?.Invoke(scoreValue);//geef een waarde mee aan de Invoke() methode
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}

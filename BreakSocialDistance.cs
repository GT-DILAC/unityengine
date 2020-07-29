using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script handles calculating if the player/ gameobject has broken social distancing rules, and
//what happens when they do. This script also holds the player/ gameobjects overall risk of infection.

public class BreakSocialDistance : MonoBehaviour
{ 

    public static double playerRisk;

    public CalculateInfected infectioncount;
    
    public static int transmissionRisk;
    private bool wearingMasks;

    public Transform player;
    public Transform other;


    private void Start()
    {

        //A rough estimate of transmission according to our model is 5% when in contact with an infected individual. If everyone
        //in the space is wearing a mask, this decreases the risk by roughly 60%. A rough estimate of risk can be:

        if (wearingMasks)
            transmissionRisk = 2;
        else
            transmissionRisk = 5;

    }

    //One method is to use a collision event to determine when the player has broken social distancing measures. 
    void OnCollisionEnter(Collision col) 
        
    {
        if (col.gameObject.tag == "player") {
            IncreaseRisk(transmissionRisk); 
        }
    }


    //Another method is to simply see if the distance between two gameobjects is less than 6ft (what this could mean in your game
    //may vary drastically.

    private void Update()
    {
        float dist = Vector2.Distance(other.position, player.position);
        if (dist <= 6)
            IncreaseRisk(transmissionRisk);
    }

    void IncreaseRisk(int risk)
    { 
        playerRisk += risk;
    }
}

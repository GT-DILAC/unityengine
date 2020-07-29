using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//This script handles how risk of infection for a player/ gameobject increases with time. We know that being in an enclosed space
//with other individuals for a sustained period increases the risk of infection.

//This risk factor hinges on risk vectors, provided below in our model, as well as the number of infected people in the space,
//which we can pull from our CalculateInfected script.


public class Timer : MonoBehaviour
{
    private float start_time;
    private float game_time = 90f; //This example uses a game length of 90 seconds. Feel free to adjust as needed


    public CalculateInfected infectioncount; //Calling in the script that calculates infected numbers.

    private double[] riskVectors = new double[] {0.486582881, 0.249819981, 0.128261855, 0.065851832, 0.033809458, 0.017358354, 0.008912076, 0.004575613, 0.002349198};
    int index = 0;


    void Start()
    {
        start_time = Time.time;
        InvokeRepeating("IncreaseRiskWithTime", 10f, 10f);
        //For this example, the 90 seconds selected represents 30 minute of real time.
        //As a result, each second represents 20 seconds of real time. We increase the risk of infection every 10 seconds(roughly every 3 minutes
        //of real time.
    }



    //To calculate risk over time, we can multiply the risk vector from the array times the number of infected in the space, times the
    //transmission risk (which is impacted by the usage of PPE. We then add this to the player's total risk of infection.
    void IncreaseRiskWithTime()
    {
        BreakSocialDistance.playerRisk += (riskVectors[index] * CalculateInfected.TotalInfected * BreakSocialDistance.transmissionRisk); 
    
    }
}


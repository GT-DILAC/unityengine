 using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// This script is responsible for determining how many individuals in the game's population are infected and healthy.


public class CalculateInfected: MonoBehaviour
{

    // Here we initialize all the variables necessary for our calculations. You may need to add more depending on your needed parameters.
    public static int TotalPopulationNum = 0;
    public static int TotalInfected = 0;
    public static int TotalHealthy = 0;
    
    public int InfectionRiskPercent; 
    private float PercentofTotalInfected;

    void Awake()
    {

        TotalPopulationNum = 250; // Change this according to the population you're trying to simulate.

        //Here we roll to see how many people within the total population are infected. This assumes a 7% chance of infection within
        //the general population of your game world. If 50% of everyone in your game world were infected, for example,
        //you should adjust the int below accordingly.

        int PercentofGeneralPopulationInfected = 8;

        for (int i = 0; i < TotalPopulationNum; i++)
        {
            int InfectionRoll = Random.Range(1, 101);

            if (InfectionRoll <= PercentofGeneralPopulationInfected)
            {
                TotalInfected += 1;
            }

            else
            {
                TotalHealthy += 1;
            }

            PercentofTotalInfected = (TotalInfected / TotalPopulationNum) * 100;

            Debug.Log("The number of infected invidiuals is " + TotalInfected + "out of " + TotalPopulationNum);
        }
    }
}
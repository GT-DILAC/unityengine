 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script creates clones of a public gameobject that you provide it with healthy and infected versions. This way. your game
//can detect which instantiated people are infected or sick. If you want to mix in variance in mask usage, you could
//also add that here.

public class People_spawner : MonoBehaviour
{
    public CalculateInfected calculateInfected;
    public GameObject PeopleToSpawn;
    public Vector3 position;

    private int totalInfected;
    private int totalHealthy;

    // Start is called before the first frame update
    void Start()
    {
        totalInfected = CalculateInfected.TotalInfected;
        totalHealthy = CalculateInfected.TotalHealthy;


        for (int i = 0; i < totalInfected; i++)
        {
            CreateInfectedPerson();
        }

        for (int i = 0; i < totalHealthy; i++)
        {
            CreateHealthyPerson();
        }
    }

    void CreateInfectedPerson()
    { 
            GameObject clone = Instantiate(PeopleToSpawn, position, Quaternion.identity);
            clone.name = "Infected";
    }

    void CreateHealthyPerson()
    {
        GameObject clone = Instantiate(PeopleToSpawn, position, Quaternion.identity);
        clone.name = "Healthy";
    }  
}







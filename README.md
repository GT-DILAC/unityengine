# unityengine
A Unity-based simulation engine for creating COVID-related games based on epidemiological data.

***Description of Files***

These Unity scripts are intended to help you get started in simulating how COVID infection risk can change when individuals are sharing a space for a discrete amount of time.

The key parameters this model considers are: -- Current infection rate in a population -- Risk of infection when social distancing is broken -- Risk of infection when PPE (masks) are used -- Risk of infection over time when sharing space with others

There are four scripts in this library that you can import into your Unity project: 1). CalculateInfected 2). BreakSocialDistance 3). Timer 4). People_Spanwer

1 -- Calcluate Infected

This script allows you to input the size of the population that you want to simulate, and then it rolls to see how many within that population are infected or not. For example, if your game takes place in a movie theatre, you could input the size of the crowd (perhaps 50) and on each runtime generate a random (as determined by the model) number of infected and healthy people in the space.

2 -- BreakSocialDistance

This script does two things: first, it stores the player's (or gameobjects) risk of infection, and it updates that risk of infection based upon its ability to maintain social distance. If it breaks social distancing, their risk of infection increases, depending on the usage of masks by individuals in the store.

There are two ways to determine if social distance is broken: a collision event, or the result of a distance function.

3 -- Timer

This script calculates the player's risk of infection over time. This risk is determined by two factors: the number of infected people in the space, as well as how long the player spends in the dangerous area. There are 9 risk vectors within the script that can be used as checkpoints during the player's time spent in the space. When the checkpoint is reached, the player's risk of infection increases according to the parameters.

4 -- People_Spawner

This script enables the user to easily instantiate NPCs or players and divide them into subsets of healthy and infected.

Note: Most scripts reference the CalculateInfected script, and require that a public reference within the scene is given to it.

DISCLAIMER: Please note that the values and model equations are only approximations and not an accurate representation of the pandemic. They are meant for educational purposes only and should not be used to make predictions about the COVID-19 pandemic.

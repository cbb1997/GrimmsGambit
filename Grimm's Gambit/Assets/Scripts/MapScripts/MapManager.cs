using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code by Jessie Archer
public class MapManager : MonoBehaviour
{
    static MapPlayer player;//The player used on the map scene

    static bool startingSpaceUsed = false;//Checks to see if the player has moved to a starting space. Prevents moving horizontally

    //Finds the player in the scene
    void Start()
    {
        player = FindObjectOfType<MapPlayer>();
    }

    //Retrieves the player
    public static MapPlayer GetPlayer()
    {
        return player; 
    }

    //Checks if the starting space has been used
    public static bool GetStartingSpaceUsed()
    {
        return startingSpaceUsed;
    }

    //Sets the starting space to used 
    public static void SetStartingSpaceUsed()
    {
        startingSpaceUsed = true;
    }
}

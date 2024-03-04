using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataManager : MonoBehaviour
{


    public static dataManager Instance;



    // Sample bool Data
    public bool bridge;


    private void Awake()
    {
        if (Instance != null){

            Destroy(gameObject);
            return;

        }
        
        Instance = this;
        // Mark a GameObject to be saved in memory - EVEN if a new scene is loaded 
        DontDestroyOnLoad(gameObject);
    }
}

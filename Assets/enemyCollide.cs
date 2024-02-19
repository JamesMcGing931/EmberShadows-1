using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyCollide : MonoBehaviour
{
    public ItemManager im;
    public float spotlightRadiusIncrease = 1f;
    public GameObject player;
    public Text fireflyText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            DecreasePlayerSpotlightRadius();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DecreasePlayerSpotlightRadius()
    {
        SpotlightPulse playerSpotlight = player.GetComponentInChildren<SpotlightPulse>();
        if (playerSpotlight != null)
        {
            // Increase min and max outer radius
            playerSpotlight.minOuterRadius -= spotlightRadiusIncrease;
            playerSpotlight.maxOuterRadius -= spotlightRadiusIncrease;

            Debug.Log("Min Outer Radius: " + playerSpotlight.minOuterRadius);
            Debug.Log("Max Outer Radius: " + playerSpotlight.maxOuterRadius);
            im.flyCount--;
            Debug.Log("Items: " + im.flyCount);
            fireflyText.text = im.flyCount.ToString();


        }
        else
        {
            Debug.LogWarning("Player's spotlight not found!");
        }
    }
}

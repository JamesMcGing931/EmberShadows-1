using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagerJ : MonoBehaviour
{

    Animator animator;

    ItemHealth itemHealth;

    bool deathTriggered = false;

    public int destroyTimer = 1;
    public ItemManager im;



    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        itemHealth = gameObject.GetComponent<ItemHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Enemys: " + im.enemyCount);

        if (itemHealth.health <= 0 && !deathTriggered)
        {

            //Trigger Death Animation
            im.enemyCount--;
           

            animator.SetTrigger("Death");

            deathTriggered = true;

            StartCoroutine(DestroyGameObject(destroyTimer));
        }

    }

    IEnumerator DestroyGameObject(int delayTime)
    {
        yield return new WaitForSeconds(delayTime);

        Destroy(gameObject);
    }
}

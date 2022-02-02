using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombblast : MonoBehaviour
{
    private Rigidbody BombRb;
   // private float movementForce = 8;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BlastTiming());
        player = GameObject.Find("Player");
        BombRb = GetComponent<Rigidbody>();
       
    }

  

    IEnumerator BlastTiming()
    {
        yield return new WaitForSeconds(2.5f);
        BombBlast();

    }

    void BombBlast()
    {
          Debug.Log("Hello Bomb");
        Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);
        foreach (Collider items in colliders)
        {
            //if (items.gameObject.CompareTag("Enemy"))
              //  Destroy(items.gameObject);
            if (player != null && items.gameObject.CompareTag("Player"))
            {

                player.GetComponent<PlayerController>().health--;
                Debug.Log(player.GetComponent<PlayerController>().health);
            }


        }

    }

}

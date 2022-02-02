using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bombPrefb;
    private GameObject laucher;
    private float launchervelocity = 400f;
    public PlayerController Player;
    public GameObject Sticky;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            laucher = Instantiate(bombPrefb, transform.position, transform.rotation);
            laucher.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, launchervelocity,
                launchervelocity));
        }

        if (Player.multiplebomb && Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < 2; i++)
            {
                laucher = Instantiate(bombPrefb, transform.position, transform.rotation);
                laucher.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchervelocity,
                    launchervelocity));
            }
            
        }

        if (Player.Sticky && Input.GetKeyDown(KeyCode.Space))
        {
           // for (int i = 0; i < 2; i++)
            
                laucher = Instantiate(Sticky, transform.position, transform.rotation);
                laucher.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchervelocity,
                    launchervelocity));
            

        }

    }
}

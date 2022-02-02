using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyrotation : MonoBehaviour
{
    private Rigidbody bombRb;

    // Start is called before the first frame update
    void Start()
    {
        bombRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
            bombRb.isKinematic = true;
        if (collision.gameObject.CompareTag("Player"))
        {
            bombRb.isKinematic = true;
            transform.parent = (collision.gameObject.transform);
        }

    }
}

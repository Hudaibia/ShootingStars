using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    private float leftright;
    public bool multiplebomb = false;
    public bool Sticky = false;
    public int health = 5;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        leftright = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.right * speed * Time.deltaTime * leftright);
        playerRb.AddForce(Vector3.forward * speed * Time.deltaTime * forwardInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("multiplebomb"))
        {
            Destroy(other.gameObject);
            multiplebomb = true;
        }
    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        multiplebomb = false;
        
    }
}

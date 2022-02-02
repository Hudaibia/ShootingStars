using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStriking : MonoBehaviour
{
    private Vector3 Direction;
    private float speed = 2;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Direction = (player.transform.position - transform.position).normalized;
        transform.Translate(Direction * speed * Time.deltaTime);

        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float moveSpeed;

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate( 0, -moveSpeed, 0);

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            GameObject gameMager = GameObject.Find("GameManger");
            gameMager.GetComponent<GameManger>().HurtHP();

            Destroy(gameObject);
        }

        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}

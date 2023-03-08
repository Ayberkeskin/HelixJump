using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManeger gm;


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y>=ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}

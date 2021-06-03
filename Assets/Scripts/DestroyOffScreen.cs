using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        var playerPosition = player.transform.position;
        var objectPosition = gameObject.transform.position;

        if (playerPosition.z - 90f >= objectPosition.z)
        {
            Destroy(gameObject);
        }
    }
}

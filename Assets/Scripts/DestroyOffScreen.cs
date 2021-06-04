using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    private GameObject player;

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

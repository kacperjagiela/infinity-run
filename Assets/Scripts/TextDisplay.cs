using UnityEngine.UI;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    public Text pointsText;
    public Text distanceText;

    private GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        pointsText.text = "Points: " + Manager.Instance.points.ToString();
        distanceText.text = "Distance: " + ((int)player.transform.position.z).ToString();
    }
}
using UnityEngine;

public class Points : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Manager.Instance.points += 1;
    }
}

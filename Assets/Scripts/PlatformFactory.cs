using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFactory : MonoBehaviour
{

    public GameObject platformPrefab;
    int numberOfPlatforms = 0;

    private void Awake()
    {
        InvokeRepeating("createPlatform", 1.5f, 0.5f);
    }

    void createPlatform()
    {
        Instantiate(platformPrefab, new Vector3(0, 0, numberOfPlatforms * 29.9F), Quaternion.identity);
        numberOfPlatforms++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFactory : MonoBehaviour
{

    public GameObject platformPrefab;
    int numberOfPlatforms = 0;

    private void Awake()
    {
        InvokeRepeating("createPlatform", 2f, 0.3f);
    }

    void createPlatform()
    {
        Instantiate(platformPrefab, new Vector3(0, 0, numberOfPlatforms * 29.9F * -1), Quaternion.identity);
        numberOfPlatforms++;
    }
}

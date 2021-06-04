using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsFactory : MonoBehaviour
{
    public GameObject pointsPrefab;

    int[] pointsPositions = new int[5] { -4, -2, 0, 2, 4 };
    int numberOfPoints = 2;

    private void Awake()
    {
        InvokeRepeating("createPoint", 0.5f, 1f);
    }

    void createPoint()
    {
        Instantiate(pointsPrefab, new Vector3(pointsPositions[Random.Range(0, 5)], 1f, numberOfPoints * 15F), Quaternion.identity);
        numberOfPoints++;
    }
}

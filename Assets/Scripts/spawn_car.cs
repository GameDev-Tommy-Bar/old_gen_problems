using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    [SerializeField] private GameObject car;
    private Vector3 positionOfSpawnedObject;
    private Quaternion rotationOfSpawnedObject = Quaternion.identity;
    [SerializeField] private float minDelay = 1f;
    [SerializeField] private float maxDelay = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        positionOfSpawnedObject = transform.position;
        StartCoroutine(SpawnCarCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnCarCoroutine()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            Instantiate(car, positionOfSpawnedObject, rotationOfSpawnedObject);
        }
    }
}

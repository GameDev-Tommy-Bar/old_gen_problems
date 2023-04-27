using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_car : MonoBehaviour
{
    [SerializeField] GameObject car;
    Vector3 positionOfSpawnedObject;
    Quaternion rotationOfSpawnedObject = Quaternion.identity;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        positionOfSpawnedObject = transform.position;
        StartCoroutine(SpawnCar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnCar()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            Instantiate(car, positionOfSpawnedObject, rotationOfSpawnedObject);
        }
    }
}

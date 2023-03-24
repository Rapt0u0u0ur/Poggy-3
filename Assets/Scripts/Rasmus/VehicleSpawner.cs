using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    int time;
    public int spawnedDirection;
    public GameObject testCar;
    GameObject spawnedObject;
    GameObject EPA;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicle", 2, 0.0385f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnVehicle()
    {
        if (Random.Range(1, 10) == 1)
        {
            int randomCar = Random.Range(1, 4);
            if (randomCar == 1)
            {
                spawnedObject = Instantiate(testCar, transform.position, Quaternion.identity, transform);
            }
            else if (randomCar == 2)
            {
                spawnedObject = Instantiate(testCar, transform.position, Quaternion.identity, transform);
            }
            else if (randomCar == 3)
            {
                spawnedObject = Instantiate(testCar, transform.position, Quaternion.identity, transform);
            }
            else if (randomCar == 4)
            {
                spawnedObject = Instantiate(testCar, transform.position, Quaternion.identity, transform);
            }
            spawnedObject.GetComponent<Vehicle>().directionInt = spawnedDirection;
            CancelInvoke();
            InvokeRepeating("SpawnVehicle", 0.2f, 0.1f);
            if (time >= 90)
            {
                CancelInvoke();
                SpawnEpa();
            }
        }
    }
    void SpawnEpa()
    {
        Instantiate(EPA, transform.position, Quaternion.identity);
    }
    void SpawnEpaCar()
    {

    }
    private void OnBecameVisible()
    {
        InvokeRepeating("IncreaseTime", 0, 1);
    }
    private void OnBecameInvisible()
    {
        ResetTime();
    }
    void IncreaseTime()
    {
        time++;
    }
    void ResetTime()
    {
        time = 0;
    }
}

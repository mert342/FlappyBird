using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy birdscript;
    public GameObject borular;
    public float height;
    public float time;


    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!birdscript.isDead)
        {
            Instantiate(borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}

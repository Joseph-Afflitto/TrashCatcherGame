using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] trash;
    public GameObject bomb;

    public float xBounds, yBound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomTrash = Random.Range(0, trash.Length);

        if (Random.value <= .6f)
            Instantiate(trash[randomTrash],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        else
            Instantiate(bomb,
                new Vector2(Random.Range(xBounds, xBounds), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MonsterSpawner : MonoBehaviour
{
    public List<Monster> availableMonsterPrefab;
    public MeshFilter meshFilter;
    public AudioSource spawnAudioSource;

    private static Monster spawnedMonster;
    

    void Awake()
    {
        
    }


    private void SpawnMonster()
    {
        if (spawnedMonster != null)
        {
            return;
        }

        var selectedPrefab = availableMonsterPrefab[Random.Range(0, availableMonsterPrefab.Count)];
        var position = transform.position + meshFilter.mesh.bounds.center;

        spawnedMonster = Instantiate(selectedPrefab, position, Quaternion.identity);

        FindObjectOfType<ARPlaneManager>().subsystem
    }
}

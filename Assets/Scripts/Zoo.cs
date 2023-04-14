using System.Collections;
using System.Collections.Generic;
using Lesson_6;
using Lesson_6.Animals;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    public List<GameObject> AnimalPrefabs;
    public GameObject AnimalPenPrefab;

    public List<AnimalPen> Pens;
    public List<Animal> AllAnimals;

    public List<int> AnimalSpawnCount = new List<int>(8);
    public List<int> AnimalPrefabWish = new List<int>(8);

    public GameObject[] spawnLocations;

    void Start()
    {
        Pens = new List<AnimalPen>();
        AllAnimals = new List<Animal>();

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("SpawnLocations");
        spawnLocations = gameObjects;

        for (int i = 0; i < 8; i++)
        {
            Vector3 spawn = spawnLocations[i].transform.position;
            AnimalPen pen = Spawner(i, spawn);
            AllAnimals.AddRange(pen.Animals);
            Pens.Add(pen);
        }
    }

    private AnimalPen Spawner(int counter, Vector3 spawnLocation)
    {
        //Spawn animal pen
        GameObject go = Instantiate(AnimalPenPrefab, transform);
        //Set the position of the pen to be 50 units away from the previous pen in both x and z
        go.transform.SetPositionAndRotation(spawnLocation, Quaternion.identity);
        AnimalPen pen = go.GetComponent<AnimalPen>();

        Dictionary<GameObject, int> spawns = new Dictionary<GameObject, int>();

        spawns.Add(AnimalPrefabs[AnimalPrefabWish[counter]], AnimalSpawnCount[counter]);
        pen.SpawnAnimals(spawns);

        return pen;
    }
}

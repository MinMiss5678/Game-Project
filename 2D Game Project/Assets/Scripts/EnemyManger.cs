using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    public Transform canvas;

    public static EnemyManger instance;

    void Awake()
    {
        instance = this;
    }

    void CreateNewEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);

        curEnemy = obj.GetComponent<Enemy>();
    }

    public void DefeatEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
        CreateNewEnemy();
        Gamemanager.instance.BackgroundCheck();
    }
}

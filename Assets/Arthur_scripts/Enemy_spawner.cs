using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawner : MonoBehaviour
{
    // Element с 1 по 2 - координаты x, z вершин плоскости
    public float[] coord1 = new float[2];
    public float[] coord2 = new float[2];
    public float[] coord3 = new float[2];
    public float[] coord4 = new float[2];
    private int count_corn_spawn;
    private float[][] coords_mas;
    public GameObject enemy;
    public int enemies_count_on_corn;
    private int enemies_count_on_corn_copy;
    public float spawn_time_range;
    private Vector3 vect;
    public int vave_count;

    private void Start()
    {
        coords_mas = new float[][] { coord1, coord2, coord3, coord4 };
        enemies_count_on_corn_copy = enemies_count_on_corn;
    }

    private void Update()
    {
        if (vave_count > 0)
            Spawn();
    }

    private void Spawn()
    {
        vave_count -= 1;
        count_corn_spawn = Random.Range(1, 4);
        for (int i = 0; i < count_corn_spawn; i++)
        {
            vect = new Vector3(coords_mas[i][0], 0, coords_mas[i][1]);
            Invoke("Spawn_enemie", 1f);
        }
    }

    private void Spawn_enemie()
    {
        enemies_count_on_corn -= 1;
        Instantiate(enemy, vect, Quaternion.identity);
        if (enemies_count_on_corn != 0)
            Invoke("Spawn_enemie", spawn_time_range);
        else
            enemies_count_on_corn = enemies_count_on_corn_copy;
    }
}

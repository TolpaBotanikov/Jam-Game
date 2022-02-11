using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawner : MonoBehaviour
{
    public Vector3 coord1;
    public Vector3 coord2;
    public Vector3 coord3;
    public Vector3 coord4;
    public GameObject portal;
    private int count_corn_spawn;
    private Vector3[] coords_mas;
    public GameObject enemy;
    public int enemies_count_on_corn;
    private int enemies_count_on_corn_copy;
    public float spawn_time_range;
    private Vector3 vect;
    private int i;

    private void Start()
    {
        coords_mas = new Vector3[] { coord1, coord2, coord3, coord4 };
        enemies_count_on_corn_copy = enemies_count_on_corn;
        i = 0;
        count_corn_spawn = Random.Range(1, 4);
    }

    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (count_corn_spawn > 0)
        {
            count_corn_spawn -= 1;
            Invoke("Spawn_enemie", 1f);
        }
    }

    private void Spawn_enemie()
    {
        vect = new Vector3(coords_mas[i].x, 0.5f, coords_mas[i].z);
        enemies_count_on_corn -= 1;
        GameObject gb = Instantiate(enemy, vect, Quaternion.identity);
        gb.transform.Rotate(-90, 0, 0);
        Path tar = gb.GetComponent<Path>();
        tar.target = portal;
        if (enemies_count_on_corn != 0)
            Invoke("Spawn_enemie", spawn_time_range);
        else
        {
            enemies_count_on_corn = enemies_count_on_corn_copy;
            i++;
        }
    }
}

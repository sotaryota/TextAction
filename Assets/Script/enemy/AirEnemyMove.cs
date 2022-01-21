using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemyMove: MonoBehaviour
{
    public Vector2 enemypos;

    // Start is called before the first frame update
    void Start()
    {
        enemypos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(enemypos.x, -(Mathf.Sin(Time.time)) * 1.5f + enemypos.y);
    }
}

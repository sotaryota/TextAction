using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemyMove3 : MonoBehaviour
{
    Vector2 enemypos;
    float Distance = 10f;

    // Start is called before the first frame update
    void Start()
    {
        enemypos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(enemypos.x, Mathf.PingPong(Time.time*13f,Distance) + enemypos.y);
    }
}

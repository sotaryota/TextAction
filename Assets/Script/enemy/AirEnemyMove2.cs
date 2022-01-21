using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemyMove2 : MonoBehaviour
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
        transform.Translate(-15f * Time.deltaTime, 0, 0);
    }
}

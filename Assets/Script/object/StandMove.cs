using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandMove : MonoBehaviour
{
    public float Moving = 4f;
    public Vector2 standpos;
    // Start is called before the first frame update
    void Start()
    {
        standpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(standpos.x, Mathf.PingPong(Time.time*2.0f,Moving) + standpos.y);
    }
}

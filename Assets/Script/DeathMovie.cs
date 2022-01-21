using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMovie : MonoBehaviour
{
    float cnt = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cnt += Time.deltaTime;
        if (cnt >= 7.0f)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

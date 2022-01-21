using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    float time = 0f;
    float time2 = 0f;
    float time3 = 0f;
    public Text text;
    public RectTransform a,b,c,d,e,f,g,h,i,j,k,l;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        if (time2 <= 88.0f)
        {
            a.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            b.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            c.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            d.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            e.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            f.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            g.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            h.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            i.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            j.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            k.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
            l.position += new Vector3(0f, 32f * Time.deltaTime, 0f);
        }
        else
        {
            time3 += Time.deltaTime;
        }

        if(time3 >= 10f && time3 < 35f)
        {
            k.position += new Vector3(0f, 35f * Time.deltaTime, 0f);
            l.position += new Vector3(0f, 35f * Time.deltaTime, 0f);
        }
        else if(time3 >= 35f)
        {
            text.text = "Spaceキーでスキップ";
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
        if (time >= 184f)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

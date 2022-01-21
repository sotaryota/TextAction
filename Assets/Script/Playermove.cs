using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class Playermove : MonoBehaviour
{
    Rigidbody2D playerRb;
    GameObject[] enemy;
    
    //�W�����v
    bool jump = false;
    public float flap = 300f;
   
    //�ړ�
    float direction = 0f;
    public float scroll = 5f;

    bool cnt = false;
    VideoPlayer video;
    float timecnt = 0f;

    bool player = true;

    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Vector2 t_pos = transform.position;
        video = GetComponent<VideoPlayer>();
        bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (Input.GetKey(KeyCode.RightArrow)) //�E�ړ�
            {
                direction = 1f;
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) //���ړ�
            {

                direction = -1f;
            }
            else
            {
                direction = 0f;
            }

            playerRb.velocity = new Vector2(scroll * direction, playerRb.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space) && !jump) //�n��ɂ���ԂɃX�y�[�X�������ꂽ��W�����v
            {
                playerRb.AddForce(Vector2.up * flap);
                jump = true;
            }
        }
        if(cnt)
        {
            timecnt += Time.deltaTime;
            if(timecnt >= 1.5f)
            {
                SceneManager.LoadScene("DeathScene");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
        //�G�Ƃ̔���
        if (other.gameObject.CompareTag("enemy"))
        {
            bgm.Stop();
            player = false;
            video.Play();
            cnt = true;
        }
        if (other.gameObject.CompareTag("end") && player)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}

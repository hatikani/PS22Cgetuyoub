using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UniRx;
using DG.Tweening;



public class PlayeControl : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float Speed = 0.3f;//横移動の速さの変数
    private float JmupPow = 10;　//ジャンプパワー
    private float moveX;　//横移動に使うときの変数
    private float Gravity = 0.3f;　//空中に居る時に掛かる重力
  //  private float time;


    private float distance = 1f; //Rayの長さ

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // time = 0;
       
       
       

    }

    // Update is called once per frame
    void Update()
    {
        //Rayを使って地面に接触しているかの判定
        Vector3 rayPos = transform.position + new Vector3(0, 0, 0);
        Ray ray = new Ray(rayPos, Vector3.down);
        bool Ground = Physics.Raycast(ray, distance);

        //横移動
        moveX = Input.GetAxis("Horizontal") * Speed;
        rb.AddForce(transform.right * moveX, ForceMode.Impulse);
        //  var moveX = (Input.GetAxis("Horizontal") * Speed) => { rb.AddForce(moveX * transform.right, ForceMode.Impulse);};

        //ジャンプ
        if (Ground)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * JmupPow, ForceMode.Impulse);
            }

        }
      //Input.GetAxis("")
      //  (Input.GetAxis("Horizontal") * Speed);

        //空中に一定時間居ると重力が掛かる。
        if (!Ground)
        {
            Vector3 vec = new Vector3(moveX, 0, 0);
            rb.velocity = vec.normalized * Gravity + new Vector3(moveX, rb.velocity.y, 0);
           
        }
    }
    public void MaterialA()
    {
        GetComponent<Renderer>().material.color = Color.red;

    }
    public void MaterialB()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}

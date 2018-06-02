using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    void Start()  //游戏运行后定义变量什么的  先运行Start 函数
    {

    }
    // Update is called once per frame
    void Update()   //Update 一秒20铮 左右一般用来人物的行动  还有很多函数
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))//RightArrow  UpArrow   LeftArrow DownArrow
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))//RightArrow  UpArrow   LeftArrow DownArrow
        {
            transform.Translate(Vector3.up * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))//RightArrow  UpArrow   LeftArrow DownArrow
        {
            transform.Translate(Vector3.down * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))//RightArrow  UpArrow   LeftArrow DownArrow
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
    }
}


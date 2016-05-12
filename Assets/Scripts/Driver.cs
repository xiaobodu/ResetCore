﻿using UnityEngine;
using System.Collections;
using ResetCore.Asset;
using ResetCore.Util;
using System.Collections.Generic;
using ResetCore.Data;
using ResetCore.Data.GameDatas;
using System;
using System.IO;
using ResetCore.UGUI;
using ResetCore.AOP;
using ResetCore.Event;
using ResetCore.Xml;
using System.Xml.Linq;
using ResetCore.MySQL;
using ResetCore.NetPost;


//using ResetCore.Data.GameDatas;

public class Driver : MonoSingleton<Driver> {

    
    void Awake()
    {
        Init();
    }
    int i = 0;
	// Use this for initialization
	void Start () 
    {
        //ReadXlsxData.ParseXlsx.ReadExcelFile("asdasd");
        //MySQLManager.OpenSql();
        //MySQLManager.ExecuteQuery();
        //MySQLManager.Close();

        //CoroutineTaskManager.Instance.LoopTodoByTime(() =>
        //{
        //    i++;
        //    Debug.logger.Log("当前数字" + i);
        //}, 1, -1, gameObject);

        //CoroutineTaskManager.Instance.WaitSecondTodo(() =>
        //{
        //    Destroy(gameObject);
        //}, 5);
        NetTaskDispatcher.instance.AddNetPostTask(new ExampleNetTask(new Dictionary<string, object>()
        {
            {"参数1", "哈哈哈"}
        }, (comp) => {
            Debug.logger.Log("完成咯~");
        }));
	}

    public override void Init()
    {
        base.Init();
        
    }

    //private List<GameObject> cubes = new List<GameObject>();

    void Update()
    {
        //Target.localPosition = Target.NewRotateAround(Vector3.zero, new Vector3(0, 1 * Time.deltaTime, 0));
        //Target.LookAt(Vector3.zero);
        //Target.NewLookAt(Vector3.zero);
        //Target.eulerAngles = Target.NewLookAt(Vector3.zero, new Vector3(0, 5, 0));
        //Debug.DrawLine(Target.position, Vector3.zero, Color.red);
    }
    
    
}

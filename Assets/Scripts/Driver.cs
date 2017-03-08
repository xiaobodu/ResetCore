﻿using ResetCore.Util;
using System.Collections.Generic;
using ResetCore.NetPost;
using UnityEngine;
using ResetCore.Event;
using ResetCore.Data.GameDatas.Xml;

//using ResetCore.Data.GameDatas;

public class Driver : MonoSingleton<Driver> {

    public TestComponent comp;
    


    void Awake()
    {
        EventDispatcher.TriggerEvent("asd", this.gameObject);
        EventDispatcher.TriggerEvent<GameObject>("asd", this.gameObject);
    }

    // Use this for initialization
    void Start()
    {
        HttpTaskDispatcher.AddNetGetTask("127.0.0.1/TestGET.php", new Dictionary<string, object>()
        {
            { "test", "testtest"}
        }, (www) =>
        {
            Debug.Log(www.text);
        }, (prog) =>
        {
            Debug.Log(prog);
        });
    }

    void OnDestroy()
    {
       
    }

    public override void Init()
    {
        base.Init();
    }


    void Update()
    {
        
    }
    
}

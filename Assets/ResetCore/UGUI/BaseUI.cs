﻿using UnityEngine;
using System.Collections;

namespace ResetCore.UGUI
{
    public abstract class BaseUI : MonoBehaviour
    {

        public GameObject uiRoot { get; protected set; }

        [SerializeField]
        private UIConst.UIName _uiName;
        public UIConst.UIName uiName
        {
            get { return _uiName; }
        }

        protected virtual void Awake() { }

        protected virtual void OnEnable() { }

        protected virtual void Start() { }

        public virtual void Init(ShowUIArg arg) 
        {
            if (arg == null) return;
        }
        protected virtual void Update() { }

        protected virtual void OnDisable() { }

        protected void Hide(System.Action afterAct = null)
        {
            UIManager.Instance.HideUI(uiName, afterAct);
        }
    }
}


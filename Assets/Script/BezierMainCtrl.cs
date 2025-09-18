using System;
using System.Collections;
using System.Collections.Generic;
using Script.Sample;
using UnityEngine;

public class BezierMainCtrl : MonoBehaviour
{
    [Header("Lerp")] 
    [SerializeField]
    private LerpSample lerpSample;
    [SerializeField]
    private QuadraticBezierSample quadraticBezierSample;
    
    private float mLerpTime;
    
    void Start()
    {
        lerpSample.Init(new Vector3(0, 0, 0), new Vector3(3, 0, 0),Color.yellow);
        quadraticBezierSample.Init();
    }

    private void Update()
    {
        mLerpTime += Time.deltaTime * 0.2f;
        lerpSample.Tick(mLerpTime);
        quadraticBezierSample.Tick(mLerpTime);
    }
}



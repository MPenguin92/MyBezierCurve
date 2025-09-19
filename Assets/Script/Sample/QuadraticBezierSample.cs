// QuadraticBezierSample.cs
// Created by Gavin.c
// on 2025 - 09 - 18

using UnityEngine;
using System.Collections.Generic;

namespace Script.Sample
{
    public class QuadraticBezierSample : MonoBehaviour
    {
        [SerializeField]
        private LerpSample lerpSample1;
        [SerializeField]
        private LerpSample lerpSample2;
        [SerializeField] 
        private LerpSample lerpSample3;
        [SerializeField] 
        private LerpSample lerpSample4;
        [SerializeField] 
        private LerpSample lerpSample5;
        [SerializeField] 
        private LerpSample lerpSample6;
        [SerializeField] 
        private LineDrawer lineDrawer;



        [SerializeField] 
        private Transform dot1;
        [SerializeField] 
        private Transform dot2;
        [SerializeField] 
        private Transform dot3;
        [SerializeField] 
        private Transform dot4;

        private float alpha = 1;
        
        public void Tick(float lerpTime)
        {
            alpha = Mathf.PingPong(lerpTime + 1,1);
            lerpSample1.Init(dot1.position, dot2.position,Color.yellow*alpha,Color.white*alpha,Color.white);
            lerpSample2.Init(dot2.position, dot3.position,Color.yellow*alpha,Color.white*alpha,Color.white);
            lerpSample3.Init(dot3.position, dot4.position,Color.yellow*alpha,Color.white*alpha,Color.white);
            
            lerpSample1.Tick(lerpTime);
            lerpSample2.Tick(lerpTime);
            lerpSample3.Tick(lerpTime);
            lerpSample4.Init( lerpSample1.GetLerpPos(),  lerpSample2.GetLerpPos(),Color.cyan * alpha,Color.cyan * alpha,Color.clear);
            lerpSample4.Tick(lerpTime);
            lerpSample5.Init( lerpSample2.GetLerpPos(),  lerpSample3.GetLerpPos(),Color.cyan *alpha,Color.cyan * alpha,Color.clear);
            lerpSample5.Tick(lerpTime);
            lerpSample6.Init( lerpSample4.GetLerpPos(),  lerpSample5.GetLerpPos(),Color.magenta,Color.white * alpha,Color.clear);
            lerpSample6.Tick(lerpTime);

        }
    }
}
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
        private LineDrawer lineDrawer;
        public void Init()
        {
            lerpSample1.Init(new Vector3(0, 0, 0), new Vector3(3, 3, 0),Color.yellow);
            lerpSample2.Init(new Vector3(3, 3, 0), new Vector3(6, 0, 0),Color.yellow);
        }

        private readonly List<Vector3> mPointPosList = new List<Vector3>();
        private readonly List<Vector3> mPointPosListClone = new List<Vector3>();
        
        public void Tick(float lerpTime)
        {
            lerpSample1.Tick(lerpTime);
            lerpSample2.Tick(lerpTime);
            
            lerpSample3.Init( lerpSample1.GetLerpPos(),  lerpSample2.GetLerpPos(),Color.cyan);
            lerpSample3.Tick(lerpTime);

            float t = Mathf.PingPong(lerpTime, 1);
            if (lerpTime <= 1)
            {
                mPointPosList.Add(lerpSample3.GetLerpPos());
                mPointPosListClone.Add(lerpSample3.GetLerpPos());
            }
            else
            {
                mPointPosListClone.Clear();
                for (int i = 0; i < t * mPointPosList.Count; i++)
                {
                    mPointPosListClone.Add(mPointPosList[i]);
                }
            }
     
            lineDrawer.SetPoint(mPointPosListClone,Color.cyan,Color.clear);
        }
    }
}
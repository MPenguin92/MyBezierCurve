// LerpSample.cs
// Created by Gavin.c
// on 2025 - 09 - 16

using System.Collections.Generic;
using UnityEngine;

namespace Script.Sample
{
    public class LerpSample : MonoBehaviour
    {
        [SerializeField]
        private LineDrawer lineDrawer;

        private readonly List<Vector3> mPointPosList = new List<Vector3>();
        
        private LerpData mLerpData;
        [Header("Lerp")] 
        [SerializeField]
        private LerpDot lerpDot;
        
        public void Init(Vector3 start,Vector3 end, Color tDotColor,Color lineColor,Color lineDotColor)
        {
            mPointPosList.Clear();
            mLerpData = new LerpData(start, end);
            mLerpData.GetPointList(mPointPosList);
            lineDrawer.SetPoint(mPointPosList, lineColor, lineDotColor,0.1f);
            lerpDot.SetColor(tDotColor);
        }

        public void Tick(float lerpTime)
        {
            float t = Mathf.PingPong(lerpTime, 1);
            mLerpPos = mLerpData.GetLerpPos(t);
            lerpDot.SetInfo(mLerpPos,t);
        }
        
        private Vector3 mLerpPos;
        public Vector3 GetLerpPos()
        {
            return mLerpPos;
        }

        public void GetAllTickPoint(List<Vector3> list)
        {
            float t = 0;
            while (t<=1)
            {
                list.Add(mLerpData.GetLerpPos(t));
                t += Time.deltaTime;
            }
        }
    }
}
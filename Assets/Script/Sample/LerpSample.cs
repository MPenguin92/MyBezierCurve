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
        
        public void Init(Vector3 start,Vector3 end, Color tDotColor)
        {
            mPointPosList.Clear();
            mLerpData = new LerpData(start, end);
            mLerpData.GetPointList(mPointPosList);
            lineDrawer.SetPoint(mPointPosList, Color.white, Color.white,0.1f);
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
    }
}
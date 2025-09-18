// LerpData.cs
// Created by Gavin.c
// on 2025 - 09 - 18

using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public struct LerpData
    {
        public Vector3 p0;
        public Vector3 p1;

        public LerpData(Vector3 p0, Vector3 p1)
        {
            this.p0 = p0;
            this.p1 = p1;
        }

        public Vector3 GetLerpPos(float t)
        {
            return (1 - t) * p0 + t * p1;
        }

        public void GetPointList(List<Vector3> posList)
        {
            posList.Add(p0);
            posList.Add(p1);
        }
    }
}
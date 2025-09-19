// LerpDot.cs
// Created by Gavin.c
// on 2025 - 09 - 16

using TMPro;
using UnityEngine;

namespace Script
{
    public class LerpDot : MonoBehaviour
    {
        private Renderer mObjectRenderer;
        private TextMeshProUGUI mText;

        void OnEnable()
        {
            // 获取当前物体的 Renderer
            mObjectRenderer = GetComponent<Renderer>();
        
            mText = this.GetComponentInChildren<TextMeshProUGUI>();
        }
    
        public void SetInfo(Vector3 position, float t)
        {
            transform.localPosition = position;
            mText.text = $"t = {t:F2}";
        }
    
        public void SetColor(Color color)
        {
            mObjectRenderer.material.SetColor(Util.ColorShader,color);
            mText.color = color;
        }
    
    }
}
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineDrawer : MonoBehaviour
{
    private LineRenderer mLineRenderer;

    [SerializeField] private Transform dotStart;
    [SerializeField] private Transform dotEnd;

    private void OnEnable()
    {
        mLineRenderer = this.GetComponent<LineRenderer>();
    }

    public void SetPoint(List<Vector3> pos, Color color,  Color dotColor,float width = 0.1f)
    {
        mLineRenderer.positionCount = pos.Count;
        mLineRenderer.SetPositions(pos.ToArray());
        mLineRenderer.startColor = mLineRenderer.endColor = color;

        dotStart.localPosition = pos[0];
        dotEnd.localPosition = pos[^1];
        
        
        dotStart.GetComponent<Renderer>().material.SetColor(Util.ColorShader,dotColor);
        dotEnd.GetComponent<Renderer>().material.SetColor(Util.ColorShader,dotColor);
    }
}
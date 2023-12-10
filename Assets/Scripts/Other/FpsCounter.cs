using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    [SerializeField] private TextView _countText;
    private string _fps = " FPS";
    private int avgFrameRate;
        private void Update()
        {
            float current = 0;
            current = Time.frameCount / Time.time;
            avgFrameRate = (int)current;
        _countText.SetText(avgFrameRate.ToString()+_fps);
        }
}

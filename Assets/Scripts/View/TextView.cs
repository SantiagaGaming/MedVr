using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    public void SetText(string text) => _text.text = text;

}

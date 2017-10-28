using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class RunningCode : MonoBehaviour {

    public TextAsset CodeFile;

    private TextMesh TextMesh;
    private string[] Lines;
    private int CurrentRow = 0;
    private int TotalRows = 26;
    private float Timer;
    private float Duration = 0.1f;

	void Start () {
        TextMesh = GetComponent<TextMesh>();
        Lines = Regex.Split(CodeFile.text, "\n");
        UpdateText();
	}
	
	void Update () {
        Timer += Time.deltaTime;
        if (Timer >= Duration) {
            Timer = 0;
            if (UnityEngine.Random.Range(1, 100) > 92) {
                // only a few slow ones
                Duration = UnityEngine.Random.Range(0.3f, 0.6f);
            } else {
                Duration = UnityEngine.Random.Range(0.05f, 0.2f);
            }
            UpdateText();
            CurrentRow++;
            if (CurrentRow == Lines.Length) {
                CurrentRow = 0;
            }
        }
	}

    private void UpdateText() {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < TotalRows; i++) {
            int row = CurrentRow + i;
            if (row >= Lines.Length) {
                row -= Lines.Length;
            }
            builder.AppendLine(Lines[row]);
        }
        TextMesh.text = builder.ToString();
    }
}

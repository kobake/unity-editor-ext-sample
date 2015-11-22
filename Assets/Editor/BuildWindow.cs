using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

// メニュー拡張・独自ウィンドウ・折り返し、のサンプル.
class SampleWindow : EditorWindow
{
	[MenuItem("ExtSample/SampleWindow", false, priority = 0)]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow(typeof(SampleWindow));
	}

	SampleWindow()
	{
		name = "SampleWindow";
		titleContent = new GUIContent("SampleWindow");
	}
	void OnGUI()
	{
		GUIStyle style = new GUIStyle(GUI.skin.label);
		style.wordWrap = true;
		GUILayout.Label("折り返し折り返し折り返し折り返し折り返し折り返し折り返し折り返し折り返し", style);
	}
}

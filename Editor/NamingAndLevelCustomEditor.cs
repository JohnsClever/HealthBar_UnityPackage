using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[ExecuteInEditMode]
[CustomEditor(typeof(NamingAndLevel))]
public class NamingAndLevelCustomEditor : Editor
{
	NamingAndLevel namingAndLevel;
	private void OnEnable()
	{
		namingAndLevel = (NamingAndLevel) target;
	}
	public override void OnInspectorGUI()
	{
		namingAndLevel.targetName = EditorGUILayout.TextField("Name", namingAndLevel.targetName);
		namingAndLevel.level =  EditorGUILayout.IntField("Level", namingAndLevel.level);

		if (GUILayout.Button("Update Name and Level"))
		{
			UnityEditor.Undo.RecordObject(target,"Update Text");
			namingAndLevel.RefreshSetting();
			EditorUtility.SetDirty(namingAndLevel.levelText);
			EditorUtility.SetDirty(namingAndLevel.nameText);
		}
	}
	/// <summary>
	/// Refresh name and level setting
	/// </summary>
	public void RefreshSetting()
	{
		namingAndLevel.nameText.text = namingAndLevel.name;
		namingAndLevel.levelText.text = "Level : " + namingAndLevel.level;
	}
}

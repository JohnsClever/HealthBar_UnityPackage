/*
This package was made by Eakrawi Chaisuriya 6/9/2020 V1.3
C# Unity2020.1.3f1
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[SerializeField]
public class NamingAndLevel : MonoBehaviour
{
	public string targetName = "Monster Name";
	public int level = 5;
	[HideInInspector]
	public Text nameText;
	[HideInInspector]
	public Text levelText;

	private void Awake()
	{
		RefreshSetting();
	}
	/// <summary>
	/// Refresh name and level setting
	/// </summary>
	public void RefreshSetting()
	{
		nameText.text = targetName;
		levelText.text = "Level : " + level;
	}
	/// <summary>
	/// set the name and level of this instance
	/// </summary>
	/// <param name="targetName"></param>
	/// <param name="targetLevel"></param>
	public void SetNameAndLevel(string targetName, int targetLevel)
	{
		this.targetName = targetName;
		this.level = targetLevel;
		RefreshSetting();
	}
}

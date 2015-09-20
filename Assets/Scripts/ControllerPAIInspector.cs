using UnityEngine;
using System.Collections;
using UnityEditor;


public class ControllerPAIInspector : Editor
{
	public override void OnInspectorGUI () {

		//GUILayout.Label ("This is a Label in a Custom Editor");
		ControllerPAI controllerPai = (ControllerPAI)target;

		bool allowSceneObjects = !EditorUtility.IsPersistent (target);
		controllerPai.Prefab_Fade = (GameObject)EditorGUILayout.ObjectField ("Prefab Fade", controllerPai.Prefab_Fade, typeof(GameObject), allowSceneObjects);


	}
}


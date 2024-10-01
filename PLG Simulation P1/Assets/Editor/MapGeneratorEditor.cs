using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))] //says that it is a custom editor for the Map Generator
public class MapGeneratorEditor : Editor {

	public override void OnInspectorGUI() {
		MapGenerator mapGen = (MapGenerator)target; // getting a reference to map generator (target, the object the customer editor is editing)

		//DrawDefaultInspector (); 
		if (DrawDefaultInspector ()) { //if any value was changed, it will auto update the map (so when the scale was changed so will the pam without having to repress generate
			if (mapGen.autoUpdate) {
				mapGen.GenerateMap ();
			}
		}

		if (GUILayout.Button ("Generate")) { //adds a button, if pressed generates the map
			mapGen.GenerateMap ();
		}
	}
}

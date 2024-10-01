using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour {

	public Renderer textureRender; // references the render of that plane to be able to set its texture

	public void DrawNoiseMap(float[,] noiseMap) { //takes in 2D float arrary of noise map
		int width = noiseMap.GetLength (0); // figures out the width and height of the noise map
		int height = noiseMap.GetLength (1);

		Texture2D texture = new Texture2D(width, height); // creates 2D texture with a width and height

		Color[] colourMap = new Color[width * height]; // set color of each pixel in the texture with an array
		for (int y = 0; y < height; y++) {
			for (int x = 0; x < width; x++) {
				colourMap [y * width + x] = Color.Lerp (Color.black, Color.white, noiseMap [x, y]); // creates the index for the map, and then sets the values betwean 1-0 with a color between black and white.
			}
		}
		texture.SetPixels (colourMap); //applies the colors to the texture
		texture.Apply ();

		textureRender.sharedMaterial.mainTexture = texture; // applies the texture to the texture renderer, without entering gamemore
		textureRender.transform.localScale = new Vector3 (width, 1, height); // set the size of the plane to the size of the map
	}
}

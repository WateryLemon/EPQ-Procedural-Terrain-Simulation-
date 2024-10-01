using UnityEngine;
using System.Collections;

public static class TextureGenerator //seperated the texture generation code to make it cleaner and easier to work with
{

	public static Texture2D TextureFromColorMap(Color[] colourMap, int width, int height) //creates a texture from the color map
	{
		Texture2D texture = new Texture2D(width, height);
		texture.filterMode = FilterMode.Point; //creates the pixelated texture
		texture.wrapMode = TextureWrapMode.Clamp; //removes bluriness
		texture.SetPixels(colourMap);
		texture.Apply();
		return texture;
	}


	public static Texture2D TextureFromHeightMap(float[,] heightMap) //this method gets a texture from a 2D heihght map
	{
		int width = heightMap.GetLength(0); // this is the code used to create the height map before
		int height = heightMap.GetLength(1);

		Color[] colourMap = new Color[width * height];
		for (int y = 0; y < height; y++)
		{
			for (int x = 0; x < width; x++)
			{
				colourMap[y * width + x] = Color.Lerp(Color.black, Color.white, heightMap[x, y]);
			}
		}

		return TextureFromColorMap(colourMap, width, height); //instead of creating the texture above, we return the results from the methods above, this is quicker
	}

}


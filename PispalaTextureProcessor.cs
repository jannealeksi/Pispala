using UnityEditor;
using System.Collections;

public class PispalaTextureProcessor : AssetPostprocessor
{
	public void OnPreprocessTexture ()
	{
		TextureImporter textureImporter = assetImporter as TextureImporter;
		textureImporter.mipmapEnabled = false;
		textureImporter.textureFormat = TextureImporterFormat.AutomaticTruecolor;
		textureImporter.maxTextureSize = 1024;
	}
}
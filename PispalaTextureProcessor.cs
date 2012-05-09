using UnityEditor;

public class PispalaTextureProcessor : AssetPostprocessor
{
	public void OnPreprocessTexture ()
	{
		TextureImporter textureImporter = assetImporter as TextureImporter;
		
		string[] labels = AssetDatabase.GetLabels(textureImporter);
		for(int i = 0; i < labels.Length; i++)
		{
			if(labels[i] == "imported")
				return;
		}
		
		AssetDatabase.SetLabels(textureImporter, new string[] {"imported"});
		
		textureImporter.mipmapEnabled = false;
		textureImporter.textureFormat = TextureImporterFormat.AutomaticTruecolor;
		textureImporter.maxTextureSize = 1024;		
	}
}
using UnityEditor;
using System.Collections;

public class PispalaModelProcessor : AssetPostprocessor
{
	public void OnPreprocessModel ()
	{
		ModelImporter modelImporter = assetImporter as ModelImporter;
		modelImporter.importMaterials = false;
		modelImporter.globalScale = 1;
	}
}
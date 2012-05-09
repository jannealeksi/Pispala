using UnityEditor;

public class PispalaModelProcessor : AssetPostprocessor
{
	public void OnPreprocessModel ()
	{
		ModelImporter modelImporter = assetImporter as ModelImporter;
		
		string[] labels = AssetDatabase.GetLabels(modelImporter);
		for(int i = 0; i < labels.Length; i++)
		{
			if(labels[i] == "imported")
				return;
		}
		
		AssetDatabase.SetLabels(modelImporter, new string[] {"imported"});
		
		modelImporter.importMaterials = false;
		modelImporter.globalScale = 1;
	}
}
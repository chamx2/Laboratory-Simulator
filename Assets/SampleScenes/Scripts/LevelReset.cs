using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;  // Unity 5.3 or higher, see http://docs.unity3d.com/Manual/UpgradeGuide53.html and http://docs.unity3d.com/530/Documentation/ScriptReference/SceneManagement.SceneManager.html

public class LevelReset : MonoBehaviour , IPointerClickHandler
{

	public void OnPointerClick (PointerEventData data) {

		// Reload the scene
		// Unity 5.3 or higher uses SceneManager.LoadSceneAsync instead of Application.LoadLevelAsync,
		// see http://docs.unity3d.com/Manual/UpgradeGuide53.html
		// and http://docs.unity3d.com/530/Documentation/ScriptReference/SceneManagement.SceneManager.html
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
	}

	private void Update()
	{
	}
}

using UnityEngine;
using UnityEngine.SceneManager;

public class SceneManager : MonoBehaviour
{
    #region variables
    [Header("variables")]

    [SerializeField] string moveScene;
    [SerializeField] string jumpScene;
#endregion

#region LoadScenes
    public void MoveSceneLoad() 
    {
        SceneManager.LoadScene(moveScene);
    }
    public void JumpSceneLoad() 
    {
        SceneManager.LoadScene(jumpScene);
    }
 #endregion   
}

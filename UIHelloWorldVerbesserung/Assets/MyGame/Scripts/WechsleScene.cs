using UnityEngine;
using UnityEngine.SceneManagement;

public class WechsleScene : MonoBehaviour
{
    [SerializeField] private void Loadscene()
    {
        SceneManager.LoadScene(1);
    }
}

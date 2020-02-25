using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ReturnScene");
    }

    private IEnumerator ReturnScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("TitleScene");
    }
}

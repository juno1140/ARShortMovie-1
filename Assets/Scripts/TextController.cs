using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TextController : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private TextMeshPro textMeshPro_Chika;
    private TextMeshPro textMeshPro_Riko;


    private void Start()
    {
        textMeshPro_Chika = this.GetComponent<TextMeshPro>();
        textMeshPro_Riko = obj.GetComponent<TextMeshPro>();
    }

    public void TextChange()
    {
        StartCoroutine("Change");
    }

    IEnumerator Change()
    {
        textMeshPro_Chika.text = "";
        textMeshPro_Riko.text = "";

        yield return new WaitForSeconds(3f);

        textMeshPro_Chika.text = "一緒に";

        yield return new WaitForSeconds(2f);

        textMeshPro_Chika.text = "スクールアイドル";

        yield return new WaitForSeconds(2f);

        textMeshPro_Chika.text = "はじめませんか？";

        yield return new WaitForSeconds(3f);

        textMeshPro_Chika.text = "";

        yield return new WaitForSeconds(2f);

        textMeshPro_Riko.text = "ごめんなさい！";

        yield return new WaitForSeconds(1f);

        textMeshPro_Chika.text = "えっ？";

        yield return new WaitForSeconds(2f);

        textMeshPro_Riko.text = "";
        textMeshPro_Chika.text = "ええ〜〜〜！？";
        // シェイクアニメーション
        iTween.ShakeRotation(this.gameObject, iTween.Hash("y", 100f, "z", 15f, "time", 3f));

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("EndScene");
    }
}

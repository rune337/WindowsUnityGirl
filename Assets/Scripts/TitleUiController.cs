using UnityEngine;

public class TitleUiController : MonoBehaviour
{
    public GameObject panel;
    public GameObject titleLogo;

    void Start()
    {
        panel.SetActive(false); //infoパネル非表示
    }
    public void Show()
    {
        panel.SetActive(true); //infoパネル表示
        titleLogo.SetActive(false); //タイトルロゴ非表示
    }

    public void Hide()
    {
        panel.SetActive(false); //infoパネル非表示
        titleLogo.SetActive(true); //タイトルロゴ表示
    }
}

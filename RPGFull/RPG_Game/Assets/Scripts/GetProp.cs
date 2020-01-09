using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetProp : MonoBehaviour
{
    [Header("寶箱數量介面")]
    public Text textCount;

    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;

    /// <summary>
    /// Treasure detect
    /// </summary>
    /// <param name="collision">Collision item</param>
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Treasure")
        {
            Destroy(collision.gameObject);
            propCount++;
            textCount.text = "寶箱" + propCount + "/10";

            // Winner text
            if(propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }

    void Update()
    {
        GameOver();
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GameOver()
    {
        if(finish)
        {
            // Esc離開
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            // R重來
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    // 欄位：儲存資料
    // 語法：
    // 修飾詞 類型 名稱 (指定 值)；
    // None 空值：沒東西 - 程式錯誤
    public GameObject final;

    // 碰撞偵測條件
    // 1. 兩個物件必須有碰撞器 Collider2D
    // 2. 兩者必須有至少一個剛體 Rigidbody2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們惹~");
        final.SetActive(true);  // 結束畫面.啟動設定(是) - 顯示
    }
}

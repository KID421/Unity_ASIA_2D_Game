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
    // collision 儲存碰到物件的資訊
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 判斷式 if 語法：
        // if(條件) { 條件成立時會執行的程式區塊 }
        // 如果碰到物件的名稱是傳送門就...
        if (collision.name == "傳送門")
        {
            final.SetActive(true);  // 結束畫面.啟動設定(是) - 顯示
        }
    }
}

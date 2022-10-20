using UnityEngine;
namespace greta
{
    /// <summary>
    /// 學習欄位Field
    /// </summary>
public class LearnField : MonoBehaviour
{
        //欄位 Field :儲存資料
        //語法 :
        //修飾詞 資料類型 欄位名稱 ;

        //定義一筆資料，名稱是level，類型是整數
        private readonly int level;

        //= 指定符號: 將右邊的結果給左邊
        //修飾詞: 設定資料權限
        //private私人: 僅允許此類別存取
        private int enemy = 7;
        //public公開: 允許所有類別存取
        public int hp = 100;

        // 整數
        public int countProp = 7;
        
        //浮點數
        public float speed = 3.5f;
        public float jump = 3.5F;

        //字串
        public string namePlayer = "叶";
        public string content = "めう";

        //布林值
        public bool isPass = true;
        public bool isDead = false;

        [Header("武器數量")]
        public int weaponCount = 10;
        [Tooltip("這是補充１００滴HP的紅色藥水，一罐９００元。")]
        public string propName = "紅色藥水";

        //範圍
        [Range(0, 100)]
        public int score = 60;
        [Range(1f, 10.5f)]
        public float walkSpeed = 3.7f;
        [Range(1, 7)]
        public string nameWeapon = "打火機";

        //序列化欄位
        [SerializeField]
        private string password = "1@3a978321";

        [Header("數字")]
        [Range(0, 100)]
        [SerializeField]
        private int number = 70;

        [SerializeField, Header("是否開門")]
        private bool isOpen = false;






}
}



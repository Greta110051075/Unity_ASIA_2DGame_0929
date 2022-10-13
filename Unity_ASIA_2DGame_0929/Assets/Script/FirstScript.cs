using UnityEngine;
namespace Kanae
{
    /// <summary>
    /// 第一腳本
    /// 2022.10.13
    /// </summary>

    public class FirstScript : MonoBehaviour
    {
        #region 註解區域
        //單行註解

        /*多行註解
         * 可一次撰寫多行註解
         * 或將程式區塊包在多行註解內取消程式功能
         * 最後要補上結束符號
         */

        //A和a被視為不同
        #endregion
        #region 事件區域
        //喚醒事件:遊戲開始時執行一次
        private void Awake()
        {
            //輸出(訊息);
            print("めう");  
        }

        //開始事件:Awake後執行一次
        private void Start()
        {
            print("<color=#ABD3D8>開始事件</color>");
        }
        private void Update()
        {
            print("<color=#F03C32>更新事件</color>");
        }
        #endregion

    }
}


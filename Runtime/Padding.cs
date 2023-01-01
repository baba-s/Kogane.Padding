using System;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// padding を管理する構造体
    /// </summary>
    [Serializable]
    public struct Padding
    {
        //================================================================================
        // 変数(SerializeField)
        //================================================================================
        [SerializeField] private float m_left;
        [SerializeField] private float m_right;
        [SerializeField] private float m_bottom;
        [SerializeField] private float m_top;

        //================================================================================
        // プロパティ
        //================================================================================
        public float Left   => m_left;
        public float Right  => m_right;
        public float Bottom => m_bottom;
        public float Top    => m_top;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Padding
        (
            float left,
            float right,
            float bottom,
            float top
        )
        {
            m_left   = left;
            m_right  = right;
            m_bottom = bottom;
            m_top    = top;
        }

        /// <summary>
        /// JSON 形式の文字列に変換して返します
        /// </summary>
        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}
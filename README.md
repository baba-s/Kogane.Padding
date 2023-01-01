# Kogane Padding

padding を管理する構造体

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Padding m_padding;

    private void Start()
    {
        Debug.Log( m_padding.Left );
        Debug.Log( m_padding.Top );
        Debug.Log( m_padding.Right );
        Debug.Log( m_padding.Bottom );
    }
}
```
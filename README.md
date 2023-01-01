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

![ScreenShot00006](https://user-images.githubusercontent.com/6134875/210161174-92bce1bf-9111-4c5d-a561-52408d8d2e04.png)

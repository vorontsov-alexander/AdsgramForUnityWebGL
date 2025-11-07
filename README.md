# 🎮 AdsgramForUnityWebGL  

![Unity](https://img.shields.io/badge/Unity-2021%2B-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-WebGL-blue)
![License](https://img.shields.io/badge/License-MIT-green)
[![Adsgram](https://img.shields.io/badge/Powered%20by-Adsgram.ai-orange)](https://adsgram.ai/)

---

## 🇬🇧 English

**AdsgramForUnityWebGL** — a Unity plugin that allows you to easily integrate **Adsgram** ads into your WebGL games.

### 🚀 Features
- Easy integration with [Adsgram.ai](https://adsgram.ai/)
- Supports **Rewarded** and **Interstitial** ads  
- Callback support for reward events and errors  
- Simple setup through prefab and JS API

---

### ⚙️ Installation

1. Download the `.unitypackage` file and import it into your Unity project:  
   **Assets → Import Package → Custom Package...**

2. Add the prefab named **`AdManager`** to your scene.  
3. Download and place the following files into your build folder (`Build/`):
   - `telegram-web-app.js` — Telegram Web App API  
   - `sad.min.js` — Adsgram API  

4. Open your WebGL template file:  
   `Assets/WebGLTemplates/TelegramMiniApp Template/index.html`

5. Add your Adsgram block IDs inside it:
   ```html
   const REWARDED_BLOCK_ID = "";
   const INTERSTITIAL_BLOCK_ID = "";
💻 Example Usage
```csharp
public class GameManager 
{
    [SerializeField] private AdManager adManager;

    private void Start()
    {
        if (!adManager)
            return;

        // Subscribe callbacks
        adManager.OnRewardGranted += HandleRewardGranted;
        adManager.OnInterstitialEffectAllowed += HandleInterstitialEffectAllowed;
        adManager.OnAdFailedWithReason += HandleAdFailedWithReason;
    }

    private void ShowSomeInterstitialAd()
    {
        if (adManager)
        {
            adManager.ShowInterstitial();
        }
        else
        {
            MockAd();
        }
    }

    private void ShowSomeRewardedAd()
    {
        if (adManager)
        {
            adManager.ShowRewarded();
        }
        else
        {
            HandleRewardGranted(); // Mock fallback
        }
    }

    private void HandleRewardGranted()
    {
        // Logic for giving player reward after watching a Rewarded Ad
    }

    private void HandleInterstitialEffectAllowed()
    {
        // Logic for handling Interstitial Ad effects
    }

    private void OnDestroy()
    {
        if (!adManager) return;
        adManager.OnRewardGranted -= HandleRewardGranted;
        adManager.OnInterstitialEffectAllowed -= HandleInterstitialEffectAllowed;
        adManager.OnAdFailedWithReason -= HandleAdFailedWithReason;
    }
}
```
🧩 Compatibility
Unity 2021+

Platform: WebGL

Works with Telegram Web Apps

📜 License
This project is licensed under the MIT License.
See the LICENSE file for details.

🇷🇺 Русский
AdsgramForUnityWebGL — это плагин для Unity, который позволяет легко интегрировать рекламу Adsgram в ваши WebGL-игры.

🚀 Возможности
Простая интеграция с Adsgram.ai

Поддержка Rewarded и Interstitial рекламы

Поддержка колбэков (вознаграждение, ошибки)

Простая настройка через префаб и JS API

⚙️ Установка
Скачайте файл .unitypackage и импортируйте его в проект Unity:
Assets → Import Package → Custom Package...

Добавьте на сцену префаб с названием AdManager.

Скачайте и положите в папку билда (Build/) два файла:

telegram-web-app.js — API веб-приложений Telegram

sad.min.js — Adsgram API

Откройте файл шаблона WebGL:
Assets/WebGLTemplates/TelegramMiniApp Template/index.html

Укажите в нём ID рекламных блоков:

```html
const REWARDED_BLOCK_ID = "";
const INTERSTITIAL_BLOCK_ID = "";
```
💻 Пример использования
```csharp
public class GameManager 
{
    [SerializeField] private AdManager adManager;

    private void Start()
    {
        if (!adManager)
            return;

        // Subscribe callbacks
        adManager.OnRewardGranted += HandleRewardGranted;
        adManager.OnInterstitialEffectAllowed += HandleInterstitialEffectAllowed;
        adManager.OnAdFailedWithReason += HandleAdFailedWithReason;
    }

    private void ShowSomeInterstitialAd()
    {
        if (adManager)
        {
            adManager.ShowInterstitial();
        }
        else
        {
            MockAd();
        }
    }

    private void ShowSomeRewardedAd()
    {
        if (adManager)
        {
            adManager.ShowRewarded();
        }
        else
        {
            HandleRewardGranted(); // Mock fallback
        }
    }

    private void HandleRewardGranted()
    {
        // Logic for giving player reward after watching a Rewarded Ad
    }

    private void HandleInterstitialEffectAllowed()
    {
        // Logic for handling Interstitial Ad effects
    }

    private void OnDestroy()
    {
        if (!adManager) return;
        adManager.OnRewardGranted -= HandleRewardGranted;
        adManager.OnInterstitialEffectAllowed -= HandleInterstitialEffectAllowed;
        adManager.OnAdFailedWithReason -= HandleAdFailedWithReason;
    }
}
```
🧩 Совместимость
Unity 2021+

Платформа: WebGL

Поддержка Telegram Mini Apps

📜 Лицензия
Проект распространяется по лицензии MIT.
Подробнее см. в файле LICENSE.

💡 Powered by Adsgram.ai

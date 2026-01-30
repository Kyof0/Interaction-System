# Interaction System - Emre Aslan

> Ludu Arts Unity Developer Intern Case

## Proje Bilgileri

| Bilgi | Değer |
|-------|-------|
| Unity Versiyonu | 6000.0.23f1 |
| Render Pipeline | URP |
| Case Süresi | 12 saat |
| Tamamlanma Oranı | %90 |

---

## Kurulum

1. Repository'yi klonlayın:
```bash
git clone https://github.com/Kyof0/Interaction-System.git
```

2. Unity Hub'da projeyi açın
3. `Assets/[Interaction-System]/Scenes/TestScene.unity` sahnesini açın
4. Play tuşuna basın

---

## Nasıl Test Edilir

### Kontroller

| Tuş | Aksiyon |
|-----|---------|
| WASD | Hareket |
| Mouse | Bakış yönü |
| E | Etkileşim |
| [Diğer] | [Açıklama] |

### Test Senaryoları

1. **Door Test:**
   - Kapıya yaklaşın, "Interact [E]" mesajını görün
   - E'ye basın, kapı açılsın
   - Tekrar basın, kapı kapansın

2. **Key + Locked Door Test:**
   - Kilitli kapıya yaklaşın,
   - Anahtarı bulun ve toplayın
   - Kilitli kapıya geri dönün, şimdi açılabilir olmalı

3. **Switch Test:**
   - Switch'e yaklaşın ve aktive edin
   - Bağlı nesnenin (kapı) tetiklendiğini görün
---

## Mimari Kararlar

### Interaction System Yapısı

```
[Mimari diyagram veya açıklama]
Yok.
```

**Neden bu yapıyı seçtim:**
> [Açıklama] Yok.

**Alternatifler:**
> [Düşündüğünüz diğer yaklaşımlar ve neden seçmediniz] Yok.

**Trade-off'lar:**
> [Bu yaklaşımın avantaj ve dezavantajları] Yok.

### Kullanılan Design Patterns

| Pattern | Kullanım Yeri | Neden |
|---------|---------------|-------|
| [Observer] | [Event system] | [Açıklama] |
| [State] | [Door states] | [Açıklama] |
| [vb.] | | |

---

## Ludu Arts Standartlarına Uyum

### C# Coding Conventions

| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| m_ prefix (private fields) | [x] / [ ] | |
| s_ prefix (private static) | [x] / [ ] | |
| k_ prefix (private const) | [x] / [ ] | |
| Region kullanımı | [x] / [ ] | |
| Region sırası doğru | [x] / [ ] | |
| XML documentation | [x] / [ ] | |
| Silent bypass yok | [x] / [ ] | |
| Explicit interface impl. | [x] / [ ] | |

### Naming Convention

| Kural | Uygulandı | Örnekler |
|-------|-----------|----------|
| P_ prefix (Prefab) | [x] / [ ] | P_Door, P_Chest |
| M_ prefix (Material) | [x] / [ ] | M_Door_Wood |
| T_ prefix (Texture) | [x] / [ ] | |
| SO isimlendirme | [x] / [ ] | |

### Prefab Kuralları

| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| Transform (0,0,0) | [x] / [ ] | |
| Pivot bottom-center | [x] / [ ] | |
| Collider tercihi | [x] / [ ] | Box > Capsule > Mesh |
| Hierarchy yapısı | [x] / [ ] | |

### Zorlandığım Noktalar
> [Standartları uygularken zorlandığınız yerler]

---

## Tamamlanan Özellikler

### Zorunlu (Must Have)

- [x] / [ ] Core Interaction System
  - [x] / [ ] IInteractable interface
  - [x] / [ ] InteractionDetector
  - [x] / [ ] Range kontrolü

- [x] / [ ] Interaction Types
  - [x] / [ ] Instant
  - [x] / [ ] Hold
  - [x] / [ ] Toggle

- [x] / [ ] Interactable Objects
  - [x] / [ ] Door (locked/unlocked)
  - [x] / [ ] Key Pickup
  - [x] / [ ] Switch/Lever
  - [x] / [ ] Chest/Container

- [x] / [ ] UI Feedback
  - [x] / [ ] Interaction prompt
  - [x] / [ ] Dynamic text
  - [x] / [ ] Hold progress bar
  - [x] / [ ] Cannot interact feedback

- [x] / [ ] Simple Inventory
  - [x] / [ ] Key toplama
  - [x] / [ ] UI listesi

### Bonus (Nice to Have)

- [X] Animation entegrasyonu
- [ ] Sound effects
- [X] Multiple keys / color-coded
- [ ] Interaction highlight
- [ ] Save/Load states
- [X] Chained interactions

---

## Dosya Yapısı

```
Assets/
├── InteractionSystem/
│   ├── Scripts/
│   │   └── Runtime/
│   │       ├── Core/
│   │       │   ├── BaseInteractable/
│   │       │   │   └── BaseInteractable.cs
│   │       │   │   └── HoldInteractable.cs
│   │       │   │   └── IInteractable.cs
│   │       │   │   └── InstantInteractable.cs
│   │       │   │   └── ToggleInteractable.cs
│   │       │   ├── Door.cs
│   │       │   ├── Key.cs
│   │       │   ├── Switch.cs
│   │       └── Player/
│   │          ├── PlayerInteract.cs
│   │          └── PlayerMovement.cs
│   ├── ScriptableObjects/
│   ├── Prefabs/
│   ├── Materials/
│   └── Scenes/
│       └── TestScene.unity
├── Docs/
│   ├── CSharp_Coding_Conventions.md
│   ├── Naming_Convention_Kilavuzu.md
│   └── Prefab_Asset_Kurallari.md
├── README.md
├── PROMPTS.md
└── .gitignore
```

---

## İletişim

| Bilgi | Değer |
|-------|-------|
| Ad Soyad | [Emre Aslan] |
| E-posta | [vemre@gmail.com] |
| LinkedIn | [https://www.linkedin.com/in/vemre-aslan/] |
| GitHub | [github.com/Kyof0] |

---

*Bu proje Ludu Arts Unity Developer Intern Case için hazırlanmıştır.*
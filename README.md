## 📗 : 프로젝트

---

- Name : Dino Hook
- 프로젝트 기한 : 2021년 2학기 게임 제작 기초 수업 최종 프로젝트
- 프로젝트 설명 : 리아의 갈고리 라는 게임을 레퍼런스로 게임을 제작
- Stack : Unity, C#

---

## 📽️ : 시연영상

- https://youtu.be/AIF0r0GFtEc

---



## ⚙️ : 구현 기능

- 이동
    - 좌우 이동
        - 키보드에서 W와 D 또는 방향키를 이용해 플레이어가 왼쪽, 오른쪽으로 이동 할 수 있다.
            
            ![1-ezgif.com-video-to-gif-converter (3).gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/355f39fe-2ef3-4d84-8da2-47ab7ff7b36f/d556a431-69ca-4756-ac19-70711b462c93/1-ezgif.com-video-to-gif-converter_(3).gif)
            
    - 점프
        - 키보드의 스페이스키를 누르면 플레어가 점프를 할 수 있다
            
            ![1-ezgif.com-video-to-gif-converter (4).gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/355f39fe-2ef3-4d84-8da2-47ab7ff7b36f/8afa199e-ab36-4a4c-81f5-b53f360ead52/1-ezgif.com-video-to-gif-converter_(4).gif)
            
- 갈고리
    - 갈고리 발사
        - 키보드의 E키를 눌러 마우스 커서 방향으로 갈고리를 발사함
    - 갈고리 부착
        - 갈고리가 날아가다가 ring이라는 태그의 오브젝트에 충돌하면 갈고리가 부착됨

---

## 💫 해결하지 못한 버그
---

<aside>
❓ 플레이어 이동 버그

---

📌 버그 내용

- 플레이어가 이동하다가 가끔 방향키를 입력해도 이동이 되지 않음

🛠️ 임시 해결방안

- 플레이어를 반대쪽으로 이동했다가 다시 이동시 해결
</aside>

<aside>
❓ 플레이어 점프 애니메이션 버그

---

📌 버그 내용

- 플레이어가 점프한 상태에서 땅을 밟을때 플레이어의 일부분만 땅에 닿는 경우 점프 애니메이션이 걷는 애니메이션으로 돌아오지 않음

🛠️임시 해결방안

- 다시 점프하거나 갈고리를 사용해 플레이어의 일부분이 땅에 닿는것이 아닌 플레이어의 전체부분이 땅에 닿으면 해결
</aside>

<aside>
❓ 블레이어 이동방향시점 버그

---

📌 버그 내용

- 플레이어를 이동시킬때 방향을 빠르게 바꾸면 플레이어가 진행방향이 아닌 반대방향을 보고 걷는 버그

🛠️임시 해결방안

- 방향키를 뗀 후에 다시 이동하면 해결
</aside>

💬 추후 리팩토링을 통해 버그 수정 및 코드 개선

---
### 📁 프로젝트 진행중 아쉬웠던 점

---

- 처음 Unity를 다뤄보았던 프로젝트라 기능을 많이 다루지 못한것이 아쉬움
- 카메라를 맵 오브젝트가 있는 곳 외부로 나가지 못하게하는 기능을 추가하지 못한것이 아쉬움
- 첫 Unity프로젝트라 에셋을 조금더 다양하게 구하지 못한것이 아쉬움

---
### 에셋 출처
- Awesome Jungle Pack
    - https://jesse-m.itch.io/jungle-pack
- Generic PLATFORMER Pack
    - https://bakudas.itch.io/generic-platformer-pack
- Dino Family
    - https://demching.itch.io/dino-family
- Flick's Pixels
    - https://old-flick.itch.io/flicks-pixels
- Free Pixel Food!
    - https://henrysoftware.itch.io/pixel-food








   



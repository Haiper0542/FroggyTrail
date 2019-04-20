# FroggyTrail
* #### 장르 : 아케이드 퍼즐 게임
* #### 역할 : 프로그래머(인게임 구현)
* #### 개발 언어, 툴 : C#, Unity3d

## 프로젝트 소개
### 게임 소개
* 매우 간편한 조작을 중시한 아케이드 퍼즐 게임으로, 시간 제한 안에 라운드마다 생성되는 연잎과 연꽃들을 모두 밟아야하는 게임입니다.
* 하나라도 남거나 타임 오버가 되어버릴 경우 게임 오버됩니다.
* 애드몹 및 업데이트 등의 테스트를 위해 제작되었습니다.
+ **조작법**
   + 개구리 이동 : 상하좌우 스와이프 or 키패드를 활성화하여 키패드
* **개발시 난관**
   * 자신이 현재있는 자리부터 스테이지가 생성되도록 레벨디자인을 하는 것은 불가능했습니다.
      * 투명한 개구리가 미리 플레이한 것처럼 랜덤적으로 움직이게 한 다음
      * 해당 개구리가 간 길을 표시하는 듯한 방식으로 스테이지가 생성되도록 제작하였습니다.
   * Admob과 GPGS가 동시에 적용이 되지않았습니다.
      * 여러 포스트들을 찾아보았으며 충돌하는 부분을 제거하기도 하였으나 작동하지않았음
      * 다른 개발자가 사용하던 버전을 받아서 다시 임포트하여 해결하였습니다.
+ **개선 사항**
   + 현재 스테이지 구성이 상당히 랜덤적임
      + 스테이지 구현 인공 지능을 좀 더 개선 
### 시연 영상
* [https://youtu.be/tLRCtbK1l7g](https://youtu.be/tLRCtbK1l7g) <br>

### 게임 화면
<img src="https://user-images.githubusercontent.com/40797534/56102152-ec29aa80-5f65-11e9-9d5f-cbeb9e2688c4.png" width="35%"></img>
<img src="https://user-images.githubusercontent.com/40797534/56102151-ec29aa80-5f65-11e9-8b28-9bfd8833df54.png" width="35%"></img>
<img src="https://user-images.githubusercontent.com/40797534/56102156-ecc24100-5f65-11e9-9efe-a0864e561abb.png" width="35%"></img>
<img src="https://user-images.githubusercontent.com/40797534/56102158-ecc24100-5f65-11e9-9a55-1594e898e761.png" width="35%"></img>
<img src="https://user-images.githubusercontent.com/40797534/56102159-ed5ad780-5f65-11e9-9a86-ece2375d4010.png" width="35%"></img>
<img src="https://user-images.githubusercontent.com/40797534/56102154-ecc24100-5f65-11e9-99d2-9002c295f70f.png" width="35%"></img>

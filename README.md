# (C# 코딩) BurgerKiosk

## 개요
-C# 프로그래밍학습
-핵심기능: ...
-화면구성: ...
-사용한 플랫폼: 
  -C#, .NET Windows Forms, Visual Studio, GitHub
-사용한 컨트롤:
  -Label, Button, CheckBox, RadioButton, PictureBox, GroupBox, ListBox
-사용한 기술과 구현한 기능:
    - Label, Button, CheckBox, RadioButton, ListBox, GroupBox, PictureBox 사용
    - Visual Studio를 이용하여 UI 디자인
    - Tab을 이용한 입력 포커스 제어

## 실행 화면(과제1)
-1단계 코드의 실행 스크린샷
![과제1 실행화면](img/file1.gif)

-과제 내용
  - 컨트롤 배치와 기본적인 속성 설정
  - 선택된 항목 추출 기능 구현
-구현 내용과 기능 설명
  - Label, ListBox, Button, RadioButton, CheckBox UI 배치
  - 주문하기 버튼과 초기화 버튼 구현
  - 주문하기 클릭 시 각 제품의 가격이 ListBox에 뜨고 Label에 총 가격 출력
  - 초기화 버튼 클릭 시 ListBox, totalCost, Label 모두 초기값(빈 값)으로 초기화


## 실행 화면(과제2)
-2단계 코드의 실행 스크린샷
![과제2 실행화면](img/file2.gif)

-과제 내용
  - 아무것도 선택하지 않고 주문하기 버튼을 누르면 에러 메시지 표시
-구현 내용과 기능 설명
  - 만약 어느 것도 선택되지 않았다면 label에 메뉴를 선택해주세요 메시지 표시

  
## 실행 화면(과제3)
-3단계 코드의 실행 스크린샷
![과제3 실행화면](img/file3.gif)

-과제 내용
  - 마우스 없이 키보드 입력만으로 주문이 가능하게 만들기
-구현 내용과 기능 설명
  - Tab을 이용해서 GroupBox 사이를 이동하기
  - 방향키를 이용해서 선택 아이템 사이를 이동하기
  - 스페이스바를 이용해서 아이템 선택하기
  - Enter 키로 버튼을 누르기
  
## 실행 화면(과제4)
-4단계 코드의 실행 스크린샷
![과제4 실행화면](img/file4.gif)

-과제 내용
  - RadioButton과 CheckBox에서 원하는 항목을 선택하면 그 즉시 정보들이 업데이트 되도록
-구현 내용과 기능 설명
  - 선택하는 순간 ListBox에 주문 내역이 표시되도록 설정
  - 선택하는 순간 Label에 전체 가격정보가 표시되도록 설정
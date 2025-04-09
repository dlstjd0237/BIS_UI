# 제가 프로젝트에서 사용 중인 UI 구조입니다.

## 🐲 안녕하세요! Unity 클라이언트 개발자 지망생 백인성 입니다.
![Image](https://github.com/user-attachments/assets/5ea67862-4cdb-4dcf-a4fc-575226c3f00e)

## ❓ 왜 사용하나요?   
- 다양한 프로젝트에서 일괄성 있는 코드를 작성하기 위해
- 코드 작성 시간을 간추리기 위해
- 탄탄한 UI 구조를 만들기 위해

## 🤴 UIManager는 어떤 역할을 담당하나요?  
- 모든 UI는 UIManager를 통해서만 UI 생성, 삭제를 할 수 있다.
- 모든 PopupUI는 생성 시 SetCanvas를 실행하여 필수 컴포넌트와 정렬 여부를 확인한다.
- ShowPopupUI를 하게 될 경우 Stack에 들어가게 되며 UI_Root 아래에 생성된다.
- ClosePopupUI를 하게 될 경우 Stack에 가장 늦게 들어간 UI가 Stack에서 나오게 되며 UI_Root 아래에서 삭제된다.

## 🧑‍🦲 UIBase는 어떤 역할을 담당하나요?  
- 모든 UI가 상속받아야 하는 Class
- GetComponent가 아닌 Enum을 통한 Bind로 UI 컴포넌트를 바인드
- Get을 통한 Bind된 컴포넌트를 전달
- BindEvent를 통해 UI의 기본적인 Event인 Click , PointerDown , PointerUp 과 같은 Event 등 을 UIEventHandler에게 EventType과 EventAction을 함께 전달 

## 🛞 UIEventHandler는 어떤 역할을 담당하나요?  
- UIBase에서 전달받은 Event를 Dictionary에 저장
- UI에 필요한 Event Interface를 전달받은 타입에 맞게 구현
- EventType에 맞는 Interface의 함수가 실행될 경우 Dictionary에서 EventType에 맞는 Action 실행

##  📚PopupUI는 어떤 역할을 담당하나요?
- 모든 PopupUI가 상속받아야 하는 Class
- Init에서 UIManager의 SetCanvas를 호출하여 캔버스 세팅
- 기본적인 Close와 Open 기능을 가상 함수로 구현
 
## 🖼️SceneUI는 어떤 역할을 담당하나요?
- 모든 SceneUI가 상속받아야 하는 Class
- UIManager에서 실질적으로 ShowPopupUI를 호출해 주는 Class

## 😁 마무리   
아직까지도 많이 부족한 코드이지만 점점 수정해가면서 저와 같이 성장해 나갈 코드입니다. 봐주셔서 감사합니다. 피드백은 a49918074@gmail.com으로 메일 주세요. 감사합니다.

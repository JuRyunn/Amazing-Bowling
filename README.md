# Amazing-Bowling

#### isTrigger
- 체크가 되어있지 않으면 오브젝트가 튕겨나간다.
- 오브젝트의 물리적인 표면을 없애준다.

#### Particle System
- 2D 이미지를 랜덤하게 생성해 특수효과를 만들어주는것.

#### Instantiate()
- 원본 게임 오브젝트를 넣어주면 그것을 새롭게 복사해준다.

#### Mask
- 원하지않는 객체를 필터링해 원하는 물체만 가져오게해준다.

#### Physics
- Unity에서 제공하는 물리 기능 집합 함수.

#### OverlapSphere, OverlapBox, OverlapCapsule
- 위치를 지정해주면(물체의 중심과 반지름) 그 물체의 중심에 겹치는 모든 colider를 배열로 가져와준다.

#### AddExplosionForce
- 어떤 지점의 폭발의 위치, 폭발력, 폭발 반경을 지정해주면 나 자신의 위치가 폭발의 원점으로부터 얼마나 떨어져있는지 계산해 튕겨나가는 정도를 적용해준다.


#### Tag&Layer
![image](https://user-images.githubusercontent.com/79950504/181768974-ca618df7-ef63-43ef-aad8-9d7c5cd5eb68.png)
- 두개 모두 물체를 식별할 때 사용한다.
- Tag는 1대1 비교만 가능하나 Layer는 필터링을 한번에 여러개 할 수 있다

#### Render Mode
![image](https://user-images.githubusercontent.com/79950504/181775606-c9c99efb-19a1-4eea-9b45-f01d3cf76a5f.png)
- Screen Space Overlay: 캔버스의 기본 값으로 화면 전체에 항상 떠 있게 하며 3D 오브젝트보다 먼저 그려져 오브젝트 앞에 보인다.
- Screen Space Camera: 카메라를 할당하여 카메라를 항상 따라다니게 할 수 있으며 3D 오브젝트를 기본적으로 화면 앞에 표시할 수 있다.
- World SPace: 3D 게임을 만들 때 가장 많이 사용하며 3D 공간에서 3D 오브젝트를 배치하는 것처럼 자유자재로 사용할 수있다.

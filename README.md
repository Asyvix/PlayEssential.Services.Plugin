# PlayEssential.Services.Plugin


PlayEssential의 플러그인 구현을 위한 인터페이스입니다.

기본적으로 코어 프로그램과 같은 AppDomain 내에서 실행되며 보안을 위한 권한 제한은 없습니다.

EventBridge로의 Publish를 위해서는 playessential.ahri.app에 플러그인을 등록하여야 합니다.
Publish되는 이벤트의 Id는 등록된 플러그인의 PluginId입니다.

Publish되는 인증된 플러그인들의 이벤트 Id는 아래를 참조하세요

**_Link_**

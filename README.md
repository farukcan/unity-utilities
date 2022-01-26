# Unity Utilities Türkçe - Faydalı ve Yardımcı Kodlar
Bu repo da Unity de yardımcı faydalı kodları ve kütüphaneleri sizin için listeledim. Bu kodlar çok işlevli olduğu için, her seferinde yeni bir script oluşturmadan işlerinizi halledebiliyorsunuz.

`` En iyi strateji savaşmadan kazanmaktır. En iyi komutan savaşmadan kazanandır. - Sun Tzu ``

Başka bir deyişle, ``en iyi yazılımcı kod yazmadan işi bitirendir. ``

Kod ulaşmak için başlığa tıklamanız yeterli.

### [Pool](https://gist.github.com/farukcan/3a317afc2737822e29bbb18f919f4381)
Object Pooling çok önemli bir optimizasyon yöntemidir. Objeleri her seferinde instantiate etmek yerine bir seferinde yapıp, o havuzdan çekerek aktif hale getirmek
oyunun akıcılığı konusunda büyük optimizasyon sağlar


![ss](/CTsHoqn9dq.gif)

### [RunB83](https://downgit.github.io/#/home?url=https://github.com/farukcan/unity-utilities/tree/main/RunB83)
Coroutine'leri sıkıcı buluyorsanız, javascript tarzı callbacklere bağlı bir araçla o işleri halledebilirsiniz. ``Run.After(1f,DoSomething)`` gibi açık bir şekilde heryerde coroutinelerinin yerine bunu kullanabilirsin.

![ss](https://i.imgur.com/7d8yXqm.png)

### [Haptic](https://downgit.github.io/#/home?url=https://github.com/farukcan/unity-utilities/tree/main/Haptic)
Kolayca titreşim oluşturmaya yarayan bir kütüphane ``Haptic.MediumTaptic()`` gibi basit bir kod ile Android ve iOSta titreşim oluşturabiliyorsun.

![ss](https://i.imgur.com/B5qSYLZ.png)

### [Advanced Tag](https://gist.github.com/farukcan/21c516e1c947c52f42155b2ecb048ced)
Bir objeye birden fazla tag ekleyip, (Normalde unityde her objenin bir tagı var) daha kolay sınıflandırmak için kullanabilirsin. ``AdvancedTag.GetTagList("Player")``

![ss](https://i.imgur.com/86PC2s6.png)

### [Axis Extension](https://gist.github.com/farukcan/cc64ff687f513b49ece998e381a3c488)
Yönleri daha kolay yönetmek ve karıştırmamak için bir extension.  ``AxisExtension.GetVector(transform,Axis.LEFT)`` diyerek o objenin solunun vektörünü alabiliyorsunuz. Aynı şehilde. Yönler Enum olarak ifade edildiği için, Axis tipini classe eklerseniz editörden yön seçebilirsiniz.

![ss](https://i.imgur.com/bUWb61a.png)

### [Child Selector](https://gist.github.com/farukcan/cb7865963f59d4e3e6451a11dfcc0f3a)
Bir objenin childini ismiyle (veya random) enable etmek bir kod parçasıdır. Childleri seçilmek istenen objenin üzerine eklenir. Hem koddan hemde unity editor ile kullanılabilir. Kod yazmadan sadece arayüz butonları ile menü geçişlerini yapabilirsiniz. ``selector.Select("WinScreen")``

[NextBackList](https://gist.github.com/farukcan/b23716f35b81efeee3c53c0b2180fc12) ile de objenin bir sonraki childini seçebilirsiniz. Next - Back butonlu arayüzlürde ve menü geçişlerinde iş görüyor.
[ChildSelectorSync](https://gist.github.com/farukcan/2b018fea70fea9fbbe829bb3b5c807d7) ile iki objenin aynı isimde childlarını senkronize edebilirsiniz. Komplex menu yapılarında ve arayüzlerde çok iyi iş görüyor.

![ss](https://i.imgur.com/yO3ETJ3.png)
![ss2](https://i.imgur.com/yK2sAmm.png)

### [Delay](https://gist.github.com/farukcan/ddf7dfb10759de66db5a73801073b28f)
UnityEventleri kullanmayı seviyorsanız bunu da seveceksiniz. Komutlara kod yazmadan gecikme ekleyebiliyorsunuz. Bu sayede yeni bir script oluşturmaktan kurtuluyorsunuz.

![ss](https://i.imgur.com/v8xqdDR.gif)

### [Explosion](https://gist.github.com/farukcan/861840a1872fe3a4864cb9c528087e5f)
Fiziksel bir patlama yaratmak için pratik bir kod parçası. Patlamanın çapını, şiddetini, yukarı itkisini ayarlabiliyorsunuz. Ayrıca titreşim desteği de var.

![ss](https://i.imgur.com/ksPBQiQ.gif)
